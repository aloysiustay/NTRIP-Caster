using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasterApp.Application
{
    public struct LatLonAlt
    {
        public double m_Latitude;
        public double m_Longitude;
        public double m_Altitude;
        public LatLonAlt()
        {
            m_Latitude = 0.0;
            m_Longitude = 0.0;
            m_Altitude = 0.0;
        }
        public LatLonAlt(double _lat, double _lon, double _alt)
        {
            m_Latitude = _lat;
            m_Longitude = _lon;
            m_Altitude = _alt;
        }
    }

    public class MountpointData
    {
        public string m_Host { get; set; } = string.Empty;
        public int m_Port { get; set; } = 0;
        public string m_Mountpoint { get; set; } = string.Empty;
        public string m_Identifier { get; set; } = string.Empty;
        public string m_Format { get; set; } = string.Empty;
        public string m_FormatDetails { get; set; } = string.Empty;
        public string m_Carrier { get; set; } = string.Empty;
        public string m_NavSystem { get; set; } = string.Empty;
        public string m_Network { get; set; } = string.Empty;
        public string m_Country { get; set; } = string.Empty;
        public LatLonAlt m_Coordinate { get; set; } = new LatLonAlt();
        public string m_NMEA { get; set; } = string.Empty;
        public string m_Solution { get; set; } = string.Empty;
        public string m_Generator { get; set; } = string.Empty;
        public string m_Compression { get; set; } = string.Empty;
        public string m_Authentication { get; set; } = string.Empty;
        public string m_Fee { get; set; } = string.Empty;
        public string m_Bitrate { get; set; } = string.Empty;

        public static bool TryParse(string _data, string _host, int _port, out MountpointData _mountpoint)
        {
            _mountpoint = new MountpointData();
            if (!_data.StartsWith("STR;"))
                return false;

            var parts = _data.Split(';');
            if (parts.Length < 18)
                return false;

            _mountpoint = new MountpointData
            {
                m_Host = _host,
                m_Port = _port,
                m_Mountpoint = parts[1],
                m_Identifier = parts[2],
                m_Format = parts[3],
                m_FormatDetails = parts[4],
                m_Carrier = parts[5],
                m_NavSystem = parts[6],
                m_Network = parts[7],
                m_Country = parts[8],
                m_Coordinate = new LatLonAlt
                {
                    m_Latitude = double.TryParse(parts[9], out var lat) ? lat : 0.0,
                    m_Longitude = double.TryParse(parts[10], out var lon) ? lon : 0.0,
                    m_Altitude = 0.0
                },
                m_NMEA = parts[11],
                m_Solution = parts[12],
                m_Generator = parts[13],
                m_Compression = parts[14],
                m_Authentication = parts[15],
                m_Fee = parts[16],
                m_Bitrate = parts[17]
            };

            return true;
        }
    }
}