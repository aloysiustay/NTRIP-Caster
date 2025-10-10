using CasterServer.Mountpoint;
using RtcmSharp;
using RtcmSharp.NMEA;
using RtcmSharp.RtcmNetwork;
using CasterServer.Clock;
using System.Globalization;
using System.Threading.Tasks;
using RtkMathLib;
using System.Reflection;

namespace CasterServer.Client
{
    public class ClientSession
    {
        private readonly Action<ClientSession> m_OnDisconnect;
        private readonly MountpointManager m_MountpointManager;
        private readonly RtcmTcpSocket m_Socket;
        private bool m_Disposed;

        private MountpointSession? m_Mountpoint = null;
        private long m_ReadIndex;
        CancellationTokenSource m_CancellationToken = new CancellationTokenSource();

        private bool m_UsingClosest = false;
        private bool m_UsingVRS = false;
        int m_NtripVersion = 0; //0 = NTRIP V1, 1 = NTRIP V2

        private GPGGA? m_GPGGA = null;

        public ClientSession(RtcmTcpSocket _socket, Action<ClientSession> _onDisconnect, MountpointManager _mountpointManager)
        {
            m_Socket = _socket;
            m_OnDisconnect = _onDisconnect;
            m_MountpointManager = _mountpointManager;
            m_ReadIndex = 0;
        }
        public async Task StartAsync()
        {
            if(!await ProcessRequest())
            {
                await m_Socket.SendAsync("400 BAD REQUEST\r\n");
                Dispose(); 
                return;
            }

            if (m_NtripVersion == 0)
                await ProcessNtripV1();
            else
                await ProcessNtripV2();

            Dispose();
        }
        private async Task<bool> ProcessRequest()
        {
            var requestLine = await m_Socket.ReceiveLineAsync();
            if (requestLine == null)
                return false;

            var parts = requestLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts[0] != "GET" || parts.Length < 2 || !parts[2].Contains("HTTP/"))
                return false;

            // Skip headers
            string? line;
            while (!string.IsNullOrEmpty(line = await m_Socket.ReceiveLineAsync())) { }

            string mountpoint = parts[1].TrimStart('/');
            await ProcessMountpoint(mountpoint);

            return true;
        }
        private async Task<bool> ProcessMountpoint(string _mountpoint)
        {
            if(string.IsNullOrEmpty(_mountpoint))
                return false;

            if (_mountpoint == "AUTO")
            {
                GPGGA? gpgga = await GetGPGGA();
                if (gpgga != null)
                {
                    var closest = m_MountpointManager.SearchNearestMountpoints(1, gpgga.m_Coordinates);
                    m_Mountpoint = m_MountpointManager.GetMountpointSession(closest.First().m_Mountpoint);
                    if(m_Mountpoint != null)
                        m_ReadIndex = m_Mountpoint.m_Streamer.m_Buffer.GetCurrentHead();
                    m_UsingClosest = true;
                }
            }
            else
            {
                m_Mountpoint = m_MountpointManager.GetMountpointSession(_mountpoint);
            }

            if (m_Mountpoint != null)
            {
                m_ReadIndex = m_Mountpoint.m_Streamer.m_Buffer.GetCurrentHead();
                m_Mountpoint.StreamRTCM();
                return true;
            }
            return false;
        }
        private async Task ProcessNtripV1()
        {
            if (m_Mountpoint == null)
            {
                int contentLength = m_MountpointManager.m_SourceTable.Length;
                await m_Socket.SendAsync("SOURCETABLE 200 OK\r\n");
                await m_Socket.SendAsync("Server: Caster Test\r\n");
                string timeStamp = RtcmClock.GetUtcTime().ToString("ddd, dd MMMM yyyy HH:mm:ss 'UTC'", CultureInfo.InvariantCulture);
                await m_Socket.SendAsync($"Date: {timeStamp}\r\n");
                await m_Socket.SendAsync("Content-Type: text/plain\r\n");
                await m_Socket.SendAsync($"Content-Length: {contentLength}\r\n\r\n");
                await m_Socket.SendAsync(m_MountpointManager.m_SourceTable);
                await m_Socket.SendAsync("ENDSOURCETABLE\r\n\r\n");
                return;
            }
            
            Task streamTask = StreamMountpointAsync();
            if(m_UsingClosest)
            {
                Task readTask = ReadAsync();
                await Task.WhenAny(readTask, streamTask);
                m_CancellationToken.Cancel();
                await streamTask;
                await readTask;
            }
            else
            {
                await streamTask;
            }
        }

        private async Task ProcessNtripV2()
        {
            if (m_Mountpoint == null)
            {
                int contentLength = m_MountpointManager.m_SourceTable.Length;
                await m_Socket.SendAsync("HTTP/1.1 200 OK\r\n");
                await m_Socket.SendAsync("Ntrip-Version: Ntrip/2.0\r\n");
                await m_Socket.SendAsync("Ntrip-Flags:\r\n");
                await m_Socket.SendAsync("Server: Caster Test\r\n");
                string timeStamp = RtcmClock.GetUtcTime().ToString("ddd, dd MMMM yyyy HH:mm:ss 'UTC'", CultureInfo.InvariantCulture);
                await m_Socket.SendAsync($"Date: {timeStamp}\r\n");
                await m_Socket.SendAsync("Connection: close\r\n");
                await m_Socket.SendAsync("Content-Type: gnss/sourcetable\r\n");
                await m_Socket.SendAsync($"Content-Length: {contentLength}\r\n\r\n");
                await m_Socket.SendAsync(m_MountpointManager.m_SourceTable);
                await m_Socket.SendAsync("ENDSOURCETABLE\r\n\r\n");
                return;
            }

        }
        private async Task StreamMountpointAsync()
        {
            try
            {
                while (!m_CancellationToken.Token.IsCancellationRequested)
                {
                    if (m_Mountpoint != null)
                    {
                        RtcmCircularBuffer buffer = m_Mountpoint.m_Streamer.m_Buffer;
                        RtcmPacket packet;
                        if (buffer.Read(ref m_ReadIndex, out packet))
                        {
                            if (await m_Socket.SendAsync(packet.GetFullPacket()))
                            {
                                Console.WriteLine($"Sending Packet to {m_Socket.m_Host} on Port {m_Socket.m_Port.ToString()}");
                            }
                            else
                            {
                                Console.WriteLine("Unable to send packet to client");
                                return;
                            }
                        }
                        else
                        {
                            await Task.Delay(1, m_CancellationToken.Token);
                        }
                    }
                    else
                    {
                        await Task.Delay(10, m_CancellationToken.Token);
                    }
                }
            }
            catch (TaskCanceledException)
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loop exited due to exception: {ex}");
            }
        }

        private async Task ReadAsync()
        {
            while (!m_CancellationToken.Token.IsCancellationRequested)
            {
                await Task.Delay(5000);
                //m_GPGGA = await GetGPGGA();
                await ProcessMountpoint("AUTO");
            }
        }

        private async Task<GPGGA?> GetGPGGA()
        {
            string? inputLine;
            try
            {
                inputLine = await m_Socket.ReceiveLineAsync();
            }
            catch (IOException)
            {
                return null;
            }

            if (inputLine == null)
                return null; // client disconnected

            if (inputLine.StartsWith("$GPGGA"))
            {
                Console.WriteLine($"Received GPGGA from client: {inputLine}");
                if (GPGGA.TryParse(inputLine, out GPGGA _gpgga))
                    return _gpgga;
            }

            return null;
        }

        public void Dispose()
        {
            if (m_Disposed)
                return;
            m_Disposed = true;
            m_CancellationToken.Dispose();
            m_Socket.Dispose();
            m_OnDisconnect(this);
        }
    }
}