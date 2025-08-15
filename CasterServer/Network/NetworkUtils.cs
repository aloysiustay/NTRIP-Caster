using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CasterServer.Mountpoint;
using RtkMathLib;

namespace CasterServer.Network
{
    public static class NetworkUtils
    {
        public static List<MountpointData> ParseMountpoints(string _sourcetable, string _host, int _port)
        {
            var mountpoints = new List<MountpointData>();
            var lines = _sourcetable.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                if (MountpointData.TryParse(line, _host, _port, out MountpointData _data))
                    mountpoints.Add(_data);
            }

            return mountpoints;
        }
        
        public static string FormatMountpointRequest(string _authorization, string? _mountpointName = null)
        {
            string authorization = Base64Encoder.EncodeBase64(_authorization);
            if (_mountpointName == "source" || _mountpointName == null)
            {
                return "GET / HTTP/1.0\r\n"
                + "User-Agent: NTRIP Client/1.0\r\n"
                + "Accept: */*\r\n"
                + "Connection: close\r\n"
                + "Authorization: Basic " + authorization + "\r\n"
                + "Ntrip-Version: Ntrip/2.0\r\n"
                + "\r\n";
            }
            else
            {
                return "GET /" + _mountpointName + " HTTP/1.0\r\n"
                + "User-Agent: NTRIP Client/1.0\r\n"
                + "Accept: */*\r\n"
                + "Connection: close\r\n"
                + "Authorization: Basic " + authorization + "\r\n"
                + "Ntrip-Version: Ntrip/2.0\r\n"
                + "\r\n";
            }
        }

        public static string GetSourceTable(string _host, int _port, string _authorization)
        {
            using var client = new TcpClient();
            client.Connect(_host, _port);

            using var stream = client.GetStream();
            var writer = new StreamWriter(stream) { AutoFlush = true };
            var reader = new StreamReader(stream);

            writer.Write(FormatMountpointRequest(_authorization));

            string response = reader.ReadToEnd();
            return response;
        }
    }
}
