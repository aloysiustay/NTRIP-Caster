using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasterServer.Mountpoint
{
    public struct Coordinates
    {
        public double m_Latitude { get; set; }
        public double m_Longitude { get; set; }
    }

    public class MountpointData
    {
        public string m_Host { get; set; }
        public int m_Port { get; set; }
        public string m_Mountpoint { get; set; }
        public string m_Identifier { get; set; }
        public string m_Format { get; set; }
        public string m_FormatDetails { get; set; }
        public string m_Carrier { get; set; }
        public string m_NavSystem { get; set; }
        public string m_Network { get; set; }
        public string m_Country { get; set; }
        public Coordinates m_Coordinate { get; set; }
        public string m_NMEA { get; set; }
        public string m_Solution { get; set; }
        public string m_Generator { get; set; }
        public string m_Compression { get; set; }
        public string m_Authentication { get; set; }
        public string m_Fee { get; set; }
        public string m_Bitrate { get; set; }

        public override string ToString()
        {
            return $"Mountpoint: {m_Mountpoint}\n" +
                    $"Identifier: {m_Identifier}\n" +
                    $"Format: {m_Format}\n" +
                    $"Format Details: {m_FormatDetails}\n" +
                    $"Carrier: {m_Carrier}\n" +
                    $"Navigation System: {m_NavSystem}\n" +
                    $"Network: {m_Network}\n" +
                    $"Country: {m_Country}\n" +
                    $"Latitude: {m_Coordinate.m_Latitude}\n" +
                    $"Longitude: {m_Coordinate.m_Longitude}\n" +
                    $"NMEA: {m_NMEA}\n" +
                    $"Solution: {m_Solution}\n" +
                    $"Generator: {m_Generator}\n" +
                    $"Compression: {m_Compression}\n" +
                    $"Authentication: {m_Authentication}\n" +
                    $"Fee: {m_Fee}\n" +
                    $"Bitrate: {m_Bitrate}\n";
        }
    }

}