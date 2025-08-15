using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.Hosting;
using RtkMathLib;

namespace CasterServer.Mountpoint
{
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

        public override string ToString()
        {
            return $"STR;{m_Mountpoint};{m_Identifier};{m_Format};{m_FormatDetails};{m_Carrier};{m_NavSystem};{m_Network};{m_Country};{m_Coordinate.m_Latitude};{m_Coordinate.m_Longitude};{m_NMEA};{m_Solution};{m_Generator};{m_Compression};{m_Authentication};{m_Fee};{m_Bitrate};";
                   
            //return $"Mountpoint: {m_Mountpoint}\n" +
            //        $"Identifier: {m_Identifier}\n" +
            //        $"Format: {m_Format}\n" +
            //        $"Format Details: {m_FormatDetails}\n" +
            //        $"Carrier: {m_Carrier}\n" +
            //        $"Navigation System: {m_NavSystem}\n" +
            //        $"Network: {m_Network}\n" +
            //        $"Country: {m_Country}\n" +
            //        $"Latitude: {m_Coordinate.m_Latitude}\n" +
            //        $"Longitude: {m_Coordinate.m_Longitude}\n" +
            //        $"NMEA: {m_NMEA}\n" +
            //        $"Solution: {m_Solution}\n" +
            //        $"Generator: {m_Generator}\n" +
            //        $"Compression: {m_Compression}\n" +
            //        $"Authentication: {m_Authentication}\n" +
            //        $"Fee: {m_Fee}\n" +
            //        $"Bitrate: {m_Bitrate}\n";
        }

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