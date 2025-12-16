using System.Net.Sockets;
using System.Threading;
using CasterServer.Mountpoint;
using RtcmSharp.RtcmNetwork;

namespace CasterServer.Client
{
    public class ConnectionManager
    {
        private readonly RtcmTcpListener m_Listener;
        private readonly ClientManager m_ClientManager;
        private readonly MountpointManager m_MountpointManager;

        CancellationTokenSource m_CancellationToken = new CancellationTokenSource();

        public ConnectionManager(ClientManager _clientManager, MountpointManager _mountpointManager)
        {
            m_MountpointManager = _mountpointManager;
            m_ClientManager = _clientManager;
            m_Listener = new RtcmTcpListener(2101);
        }

        public async Task StartAsync()
        {
            Console.WriteLine("NTRIP server listening...");

            while (!m_CancellationToken.Token.IsCancellationRequested)
            {
                var client = await m_Listener.AcceptTcpClientAsync();
                var requestLine = await client.ReceiveLineAsync();
                if (requestLine == null)
                {
                    await client.SendAsync("400 BAD REQUEST\r\n");
                    client.Dispose();
                    return;
                }

                var parts = requestLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts[0] == "GET" && parts.Length >= 2 && parts[2].Contains("HTTP/"))
                {
                    string? line;
                    while (!string.IsNullOrEmpty(line = await client.ReceiveLineAsync())) { }

                    string mountpoint = parts[1].TrimStart('/');

                    m_ClientManager.CreateSession(client, mountpoint);
                }
                else if (parts[0] == "SOURCE")
                {
                    var success = await client.SendAsync("ICY 200 OK\r\n");
                    if(!success)
                    {
                        client.Dispose();
                        return;
                    }

                    string mountpoint = parts[2].TrimStart('/');
                    _ = m_MountpointManager.AddMountpointClient(client, mountpoint);
                }
                else
                {
                    await client.SendAsync("400 BAD REQUEST\r\n");
                    client.Dispose();
                    return;
                }
            }
        }
    }
}
