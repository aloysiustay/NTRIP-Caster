using System.Globalization;
using System.IO;
using ClientTest;
using RtcmSharp;
using RtcmSharp.NMEA;
using RtcmSharp.RtcmMessageTypes;
using RtcmSharp.RtcmNetwork;
class Program
{
    static string gpgga = "$GPGGA,202530.00,5109.0262,N,11401.8407,W,5,40,0.5,1097.36,M,-17.00,M,18,TSTR*61\n";
    static RtcmStreamer? streamer;
    static CancellationTokenSource? cts;
    public static async Task SendGPGGA()
    {
        while(!cts.IsCancellationRequested)
        {
            await Task.Delay(5000);
            await streamer.m_TcpSocket.SendAsync(gpgga);
        }
    }
    static async Task Main(string[] args)
    {
        Task.Delay(5000).Wait();
        while (true)
        {
            Console.Write("Enter Command: ");
            string command = Console.ReadLine();

            if (command == "sourcetable")
            {
                RtcmTcpSocket socket = new RtcmTcpSocket("localhost", 2101, 4096);
                await socket.ConnectAsync();
                await socket.SendAsync(Utils.FormatMountpointRequest("aloytaytay-at-gmail.com:password"));
                string sourceTable = string.Empty;

                while (true)
                {
                    string? line = await socket.ReceiveLineAsync();
                    if (line == null)
                        break;
                    sourceTable += line;
                    sourceTable += "\r\n";
                }

                Console.WriteLine(sourceTable);
            }
            else if (command == "AUTO")
            {
                streamer = new RtcmStreamer("localhost", 2101, command);
                streamer.StartStream(Utils.FormatMountpointRequest("aloytaytay-at-gmail.com:password", command));
                
                long readIndex = streamer.m_Buffer.GetCurrentHead();
                cts = new CancellationTokenSource();
                Console.CancelKeyPress += (sender, e) =>
                {
                    e.Cancel = true;
                    cts.Cancel();
                };

                Task SendTask = SendGPGGA();

                while (!cts.IsCancellationRequested)
                {
                    Console.Write("Enter LatLon: ");
                    string? latlon = Console.ReadLine();
                    if (latlon == null)
                        break;
                    var parts = latlon.Split(' ');
                    GPGGA data;
                    GPGGA.TryParse(gpgga, out data);
                    double lat;
                    double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out lat);
                    double lon;
                    double.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out lon);

                    data.m_Coordinates = new RtkMathLib.LatLonAlt(lat, lon, 0.0);
                    gpgga = data.FormatMessage();

                    //RtcmPacket packet = new RtcmPacket();
                    //if (streamer.m_Buffer.Read(ref readIndex, out packet))
                    //{
                    //    Console.WriteLine("Received: " + packet.GetMessageType());
                    //    BaseMessage? message = RtcmUtils.ProcessMessage(packet);
                    //    if (message != null)
                    //        Console.WriteLine(message.Describe());
                    //}
                }

                await streamer.Dispose();
            }
        }
    }
}