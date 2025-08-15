using System.Runtime.InteropServices;
using CasterServer.Network;
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
        public List<KD_Candidate> SearchNearestMountpointsWithinRadius(double _radius, LatLonAlt _target)
        {
            return m_MountpointTree.SearchClosestMountpointWithinRadius(_radius * 1000, _target);
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
