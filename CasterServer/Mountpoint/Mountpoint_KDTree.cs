using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CasterServer.Mountpoint;

namespace CasterServer.Mountpoint
{
    public struct KD_Candidate
    {
        public double m_Distance;
        public string m_Mountpoint;
        public Coordinates m_Coordinate;
    };

    public class KD_Node
    {
        public int m_Depth { get; set; }
        public string m_MountpointName { get; set; }
        public Coordinates m_Coordinate { get; set; }
        public KD_Node? m_Left { get; set; }
        public KD_Node? m_Right { get; set; }

        public KD_Node(int _depth, string _mountpointName, Coordinates _coordinate)
        {
            m_Depth = _depth;
            m_MountpointName = _mountpointName;
            m_Coordinate = _coordinate;
        }
    };
    public class KD_Tree
    {
        private KD_Node? m_Root { get; set; }
        public void InitTree(List<MountpointData> _mountpoints)
        {
            m_Root = BuildTree(_mountpoints, 0);
        }
        private KD_Node? BuildTree(List<MountpointData> _mountpoints, int _depth)
        {
            if (_mountpoints.Count == 0)
                return null;

            int axis = _depth % 2; // 0 - latitude, 1 - longitude

            _mountpoints.Sort((a, b) =>
            {
                return axis == 0
                    ? a.m_Coordinate.m_Latitude.CompareTo(b.m_Coordinate.m_Latitude)
                    : a.m_Coordinate.m_Longitude.CompareTo(b.m_Coordinate.m_Longitude);
            });

            int medianIdx = _mountpoints.Count / 2;

            KD_Node node = new KD_Node(
                _depth,
                _mountpoints[medianIdx].m_Mountpoint,
                _mountpoints[medianIdx].m_Coordinate
            );

            var left = _mountpoints.GetRange(0, medianIdx);
            var right = _mountpoints.GetRange(medianIdx + 1, _mountpoints.Count - (medianIdx + 1));

            node.m_Left = BuildTree(left, _depth + 1);
            node.m_Right = BuildTree(right, _depth + 1);

            return node;
        }


    }
}
