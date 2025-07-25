using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CasterServer.Mountpoint;

namespace CasterServer.Network
{
    internal class NetworkInterface
    {
        public async Task<string> GetSourceTableAsync(string _host, int _port, string _authorization)
        {
            using var client = new TcpClient();
            await client.ConnectAsync(_host, _port);

            using var stream = client.GetStream();
            var writer = new StreamWriter(stream) { AutoFlush = true };
            var reader = new StreamReader(stream);

            // Send sourcetable request
            await writer.WriteAsync(NetworkUtils.FormatMountpointRequest(_authorization));

            // Read response
            string response = await reader.ReadToEndAsync();
            return response;
        }

        public async Task UseSourceTableAsync()
        {
            string sourceTable = await GetSourceTableAsync("3.143.243.81", 2101, "aloytaytay-at-gmail.com:password");
            List<MountpointData> data = NetworkUtils.ParseMountpoints(sourceTable, "3.143.243.81", 2101);
            foreach(MountpointData mountpoint in data)
            {
                Console.WriteLine(mountpoint.ToString());
            }
        }
    }
}
