using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CasterServer.Mountpoint;
using CasterServer.CasterMath;

namespace CasterServer.Mountpoint
{
    public struct KD_Candidate
    {
        public double m_Distance { get; set; }
        public string m_Mountpoint { get; set; }
        public Coordinates m_Coordinate { get; set; }
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

            KD_Node node = new KD_Node(_depth, _mountpoints[medianIdx].m_Mountpoint, _mountpoints[medianIdx].m_Coordinate);

            var left = _mountpoints.GetRange(0, medianIdx);
            var right = _mountpoints.GetRange(medianIdx + 1, _mountpoints.Count - (medianIdx + 1));

            node.m_Left = BuildTree(left, _depth + 1);
            node.m_Right = BuildTree(right, _depth + 1);

            return node;
        }
        public PriorityQueue<KD_Candidate, double> SearchClosestMountpoint(int _numMountpoints, Coordinates _target)
        {
            PriorityQueue<KD_Candidate, double> queue = new();
            KNearestNeighbour(m_Root, _target, _numMountpoints, 0, queue);
            return queue;
        }
        private void KNearestNeighbour(KD_Node? node, Coordinates target, int numNeighbours, int depth, PriorityQueue<KD_Candidate, double> nearestNeighbours)
        {
            if (node == null)
                return;

            double distance = MathUtils.HaversineDistance(target, node.m_Coordinate);

            if (nearestNeighbours.Count < numNeighbours)
            {
                nearestNeighbours.Enqueue(new KD_Candidate { m_Distance = distance, m_Mountpoint = node.m_MountpointName, m_Coordinate = node.m_Coordinate }, -distance);
            }
            else if (distance < nearestNeighbours.Peek().m_Distance)
            {
                nearestNeighbours.Dequeue();
                nearestNeighbours.Enqueue(new KD_Candidate { m_Distance = distance, m_Mountpoint = node.m_MountpointName, m_Coordinate = node.m_Coordinate }, -distance);
            }

            int axis = depth % 2;
            double diff = (axis == 0) ? target.m_Latitude - node.m_Coordinate.m_Latitude : target.m_Longitude - node.m_Coordinate.m_Longitude;

            var nearChild = (diff < 0.0) ? node.m_Left : node.m_Right;
            var farChild = (diff < 0.0) ? node.m_Right : node.m_Left;

            KNearestNeighbour(nearChild, target, numNeighbours, depth + 1, nearestNeighbours);

            Coordinates projectedPoint = (axis == 0)
                ? new Coordinates { m_Latitude = node.m_Coordinate.m_Latitude, m_Longitude = target.m_Longitude }
                : new Coordinates { m_Latitude = target.m_Latitude, m_Longitude = node.m_Coordinate.m_Longitude };

            double distanceToPlane = MathUtils.HaversineDistance(target, projectedPoint);

            if (nearestNeighbours.Count < numNeighbours || distanceToPlane < nearestNeighbours.Peek().m_Distance)
            {
                KNearestNeighbour(farChild, target, numNeighbours, depth + 1, nearestNeighbours);
            }
        }

        public List<KD_Candidate> SearchClosestMountpointWithinRadius(double radiusMeters, Coordinates _target)
        {
            List<KD_Candidate> list = new();
            NearestNeighbourWithinRadius(m_Root, _target, radiusMeters, 0, list);
            return list;
        }
        private void NearestNeighbourWithinRadius(KD_Node? node, Coordinates target, double radiusMeters, int depth, List<KD_Candidate> nearestNeighbours)
        {
            if (node == null)
                return;

            double distanceToMountpoint = MathUtils.HaversineDistance(target, node.m_Coordinate);

            if (distanceToMountpoint <= radiusMeters)
            {
                nearestNeighbours.Add(new KD_Candidate { m_Distance = distanceToMountpoint, m_Mountpoint = node.m_MountpointName, m_Coordinate = node.m_Coordinate });
            }

            int axis = depth % 2;
            double diff = (axis == 0) ? target.m_Latitude - node.m_Coordinate.m_Latitude : target.m_Longitude - node.m_Coordinate.m_Longitude;

            var nearChild = (diff < 0.0) ? node.m_Left : node.m_Right;
            var farChild = (diff < 0.0) ? node.m_Right : node.m_Left;

            NearestNeighbourWithinRadius(nearChild, target, radiusMeters, depth + 1, nearestNeighbours);

            Coordinates projectedPoint = (axis == 0)
                ? new Coordinates { m_Latitude = node.m_Coordinate.m_Latitude, m_Longitude = target.m_Longitude }
                : new Coordinates { m_Latitude = target.m_Latitude, m_Longitude = node.m_Coordinate.m_Longitude };

            double distanceToPlane = MathUtils.HaversineDistance(target, projectedPoint);

            if (distanceToPlane < radiusMeters)
            {
                NearestNeighbourWithinRadius(farChild, target, radiusMeters, depth + 1, nearestNeighbours);
            }
        }
    }
}
