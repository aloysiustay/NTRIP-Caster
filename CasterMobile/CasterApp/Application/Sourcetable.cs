using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtcmSharp.RtcmNetwork;

namespace CasterApp.Application
{
    public class Sourcetable
    {
        public List<MountpointData> m_Mountpoints = new();
        public async Task Request()
        {
            RtcmTcpSocket socket = new RtcmTcpSocket(ConnectionInfo.m_Host, ConnectionInfo.m_Port, 4096);
            await socket.ConnectAsync();
            await socket.SendAsync(ConnectionInfo.GetRequest());

            string sourceTable = string.Empty;

            while (true)
            {
                string? line = await socket.ReceiveLineAsync();
                if (line == null)
                    break;
                sourceTable += line;
                sourceTable += "\r\n";
            }

            m_Mountpoints = ParseMountpoints(sourceTable);
        }

        public List<MountpointData> ParseMountpoints(string _sourcetable)
        {
            var mountpoints = new List<MountpointData>();
            var lines = _sourcetable.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                if (MountpointData.TryParse(line, ConnectionInfo.m_Host, ConnectionInfo.m_Port, out MountpointData _data))
                    mountpoints.Add(_data);
            }

            return mountpoints;
        }
    }
}
