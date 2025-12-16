using System.Runtime.InteropServices;
using CasterServer.Network;
using RtcmSharp;
using RtcmSharp.RtcmMessageTypes;
using RtcmSharp.RtcmNetwork;
using RtkMathLib;

namespace CasterServer.Mountpoint
{
    public class MountpointManager
    {
        private KD_Tree m_MountpointTree { get; set; } = new();
        private Dictionary<string, MountpointSession> m_Mountpoints { get; set; } = new();
        public string m_SourceTable = string.Empty;

        public MountpointManager()
        {
            string sourceTable = NetworkUtils.GetSourceTable("3.143.243.81", 2101, "aloytaytay-at-gmail.com:password");
            Console.WriteLine(sourceTable);
            List<MountpointData> mountpoints = NetworkUtils.ParseMountpoints(sourceTable, "3.143.243.81", 2101);
            foreach (MountpointData mountpoint in mountpoints)
            {
                m_Mountpoints.TryAdd(mountpoint.m_Mountpoint, new MountpointSession(mountpoint));
                m_SourceTable += mountpoint.ToString() + "\r\n";
            }
            m_MountpointTree.InitTree(mountpoints);
        }
        public async Task AddMountpointClient(RtcmTcpSocket _client, string _mountpoint)
        {
            MountpointData data = new MountpointData();
            data.m_Mountpoint = _mountpoint;
            MountpointSession session = new MountpointSession(_client, data);
            m_Mountpoints.TryAdd(data.m_Mountpoint, session);
            session.m_Streamer.StartStream(null);
            var index = session.m_Streamer.m_Buffer.GetCurrentHead();
            bool positionDecoded= false;
            RtcmPacket packet;
            while(!positionDecoded)
            {
                if (!session.m_Streamer.m_Buffer.Read(ref index, out packet))
                    continue;

                ushort messageType = packet.GetMessageType();
                if (messageType == 1005 || messageType == 1006)
                {
                    BaseMessage? baseMessage = RtcmUtils.ProcessMessage(packet);
                    if (baseMessage != null)
                    {
                        var message = (Rtcm1005)baseMessage;
                        LatLonAlt coord = new LatLonAlt(new ECEF(message.m_AntennaECEF_X.GetScaledValue(), message.m_AntennaECEF_Y.GetScaledValue(), message.m_AntennaECEF_Z.GetScaledValue()));
                        data.m_Coordinate = coord;
                        break;
                    }
                }
            }
            m_MountpointTree.Insert(data.m_Mountpoint, data.m_Coordinate);
            m_SourceTable += data.ToString() + "\r\n";
            Console.WriteLine(_mountpoint + "successfully added");
        }

        public MountpointSession? GetMountpointSession(string _mountpoint)
        {
            return m_Mountpoints.TryGetValue(_mountpoint, out MountpointSession session) ? session : null;
        }

        public Dictionary<string, MountpointSession> GetMountpoints()
        {
            return m_Mountpoints;
        }

        public List<KD_Candidate> SearchNearestMountpoints(int _numMountpoints, LatLonAlt _target)
        {
            List<KD_Candidate> result = new List<KD_Candidate>();
            var closest = m_MountpointTree.SearchClosestMountpoint(_numMountpoints, _target);
            while (closest.Count != 0)
            {
                result.Add(closest.Dequeue());
            }
            return result;
        }
        public List<KD_Candidate> SearchNearestMountpointsWithinRadius(double _radiusKM, LatLonAlt _target)
        {
            return m_MountpointTree.SearchClosestMountpointWithinRadius(_radiusKM * 1000.0, _target);
        }
        public void Dispose()
        {
            foreach(var sess in m_Mountpoints)
            {
                sess.Value.Dispose();
            }
        }
    }
}
