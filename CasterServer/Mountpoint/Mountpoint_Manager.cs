using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasterServer.Mountpoint
{
    public class MountpointManager
    {
        public KD_Tree m_MountpointTree { get; set; } = new();
        public Dictionary<string, MountpointSession> m_Mountpoints { get; set; } = new();

        public MountpointManager()
        {
            string sourceTable = Network.NetworkUtils.GetSourceTable("3.143.243.81", 2101, "aloytaytay-at-gmail.com:password");
            List<MountpointData> mountpoints = Network.NetworkUtils.ParseMountpoints(sourceTable, "3.143.243.81", 2101);
            m_MountpointTree.InitTree(mountpoints);
            foreach(MountpointData mountpoint in mountpoints)
            {
                m_Mountpoints.TryAdd(mountpoint.m_Mountpoint, new MountpointSession(mountpoint));
            }
        }

        public MountpointSession? GetMountpointSession(string _mountpoint)
        {
            return m_Mountpoints.TryGetValue(_mountpoint, out MountpointSession session) ? session : null;
        }
    }
}
