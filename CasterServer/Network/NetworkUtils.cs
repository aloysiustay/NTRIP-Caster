using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CasterServer.Mountpoint;

namespace CasterServer.Network
{
    public static class NetworkUtils
    {
        public static List<MountpointData> ParseMountpoints(string sourcetable, string host, int port)
        {
            var mountpoints = new List<MountpointData>();
            var lines = sourcetable.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                if (!line.StartsWith("STR;")) continue;

                var parts = line.Split(';');
                if (parts.Length < 18) continue;

                mountpoints.Add(new MountpointData
                {
                    m_Host = host,
                    m_Port = port,
                    m_Mountpoint = parts[1],
                    m_Identifier = parts[2],
                    m_Format = parts[3],
                    m_FormatDetails = parts[4],
                    m_Carrier = parts[5],
                    m_NavSystem = parts[6],
                    m_Network = parts[7],
                    m_Country = parts[8],
                    m_Coordinate = new Coordinates
                    {
                        m_Latitude = double.TryParse(parts[9], out var lat) ? lat : 0.0,
                        m_Longitude = double.TryParse(parts[10], out var lon) ? lon : 0.0
                    },
                    m_NMEA = parts[11],
                    m_Solution = parts[12],
                    m_Generator = parts[13],
                    m_Compression = parts[14],
                    m_Authentication = parts[15],
                    m_Fee = parts[16],
                    m_Bitrate = parts[17]
                });
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

            writer.Write(NetworkUtils.FormatMountpointRequest(_authorization));

            string response = reader.ReadToEnd();
            return response;
        }
    }
}
