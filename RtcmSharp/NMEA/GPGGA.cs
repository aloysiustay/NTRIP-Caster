using System.Drawing;
using System.Globalization;
using CasterServer.Clock;
using RtkMathLib;

namespace RtcmSharp.NMEA
{
    public class GPGGA
    {
        public DateTimeOffset m_UtcTime { get; set; }
        public LatLonAlt m_Coordinates { get; set; }
        public double m_GeoidHeight { get; set; }
        public int m_FixQuality { get; set; }
        public int m_NumSatellites { get; set; }
        public double m_HorizontalDilutionOfPrecision { get; set; }
        public int m_AgeOfCorrectionData { get; set; }
        public string m_DiffStationId { get; set; } = string.Empty;
        public string m_RawString { get; set; } = string.Empty;
        public string FormatMessage()
        {
            string message = "$GPGGA,";

            m_UtcTime = RtcmClock.GetUtcTime();
            message += m_UtcTime.ToString("HHmmss.ff") + ',';

            message += ConvertDecimalToDms(m_Coordinates);

            message += m_FixQuality.ToString() + ',' + m_NumSatellites.ToString() + ',' + m_HorizontalDilutionOfPrecision.ToString() + ',';

            message += m_Coordinates.m_Altitude.ToString("0.00") + ",M," + m_GeoidHeight.ToString("0.00") + ",M,";

            message += m_AgeOfCorrectionData.ToString() + ',' + m_DiffStationId + '*';

            message += ComputeChecksum(message) + '\n';

            return message;
        }
        public static bool TryParse(string _string, out GPGGA _data)
        {
            _data = new GPGGA();

            if (!ValidateChecksum(_string))
                return false;

            var parts = _string.Split(',');

            if (parts.Length < 14 || parts[0] != "$GPGGA")
                return false;

            _data.m_RawString = _string;

            string hhmmss = parts[1].Split('.')[0]; // "202530"
            if (TimeSpan.TryParseExact(hhmmss, "hhmmss", CultureInfo.InvariantCulture, out TimeSpan _time))
            {
                _data.m_UtcTime = DateTime.Today.Add(_time);
            }

            double latitude = ConvertDmsToDecimal(parts[2], parts[3]);
            double longitude = ConvertDmsToDecimal(parts[4], parts[5]);

            if (Int32.TryParse(parts[6], out int _quality))
                _data.m_FixQuality = _quality;
            
            if(Int32.TryParse(parts[7], out int _numSats))
                _data.m_NumSatellites = _numSats;

            if (double.TryParse(parts[8], out double _hdop))
                _data.m_HorizontalDilutionOfPrecision = _hdop;

            double altitude = ConvertStringValueToMetres(parts[9], parts[10]);

            _data.m_Coordinates = new LatLonAlt(latitude, longitude, altitude);

            _data.m_GeoidHeight = ConvertStringValueToMetres(parts[11], parts[12]);

            if (Int32.TryParse(parts[13], out int _age))
                _data.m_AgeOfCorrectionData = _age;

            var last = parts[14].Split('*');

            _data.m_DiffStationId = last[0];

            return true;
        }

        public static bool ValidateChecksum(string _sentence)
        {
            if (!_sentence.StartsWith("$") || !_sentence.Contains("*"))
                return false;

            int asteriskIndex = _sentence.IndexOf('*');
            string data = _sentence.Substring(1, asteriskIndex - 1); // skip $

            byte checksum = 0;
            foreach (char c in data)
            {
                checksum ^= (byte)c; // XOR each character
            }

            string hexChecksum = _sentence.Substring(asteriskIndex + 1);
            if (byte.TryParse(hexChecksum, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out byte sentenceChecksum))
            {
                return checksum == sentenceChecksum;
            }

            return false;
        }
        static string ComputeChecksum(string _sentence)
        {
            if (_sentence.StartsWith("$"))
                _sentence = _sentence.Substring(1);

            int asteriskIndex = _sentence.IndexOf('*');
            if (asteriskIndex >= 0)
                _sentence = _sentence.Substring(0, asteriskIndex);

            int checksum = 0;
            foreach (char c in _sentence)
            {
                checksum ^= Convert.ToByte(c);
            }

            return checksum.ToString("X2", CultureInfo.InvariantCulture);
        }

        private static double ConvertDmsToDecimal(string _value, string _hemisphere)
        {
            if (double.TryParse(_value, NumberStyles.Float, CultureInfo.InvariantCulture, out double raw))
            {
                int degrees = (int)(raw / 100);
                double minutes = raw - (degrees * 100);
                double decimalDegrees = degrees + (minutes / 60);

                if (_hemisphere.ToUpper() == "S" || _hemisphere.ToUpper() == "W")
                    decimalDegrees = -decimalDegrees;

                return decimalDegrees;
            }

            throw new ArgumentException("Invalid latitude/longitude format.");
        }
        private static double ConvertStringValueToMetres(string _valString, string _unit)
        {
            double value = 0;
            if (double.TryParse(_valString, NumberStyles.Any, CultureInfo.InvariantCulture, out double altValue))
            {
                value = _unit.ToUpper() switch
                {
                    "M" => altValue,
                    "KM" => altValue * 1000.0,
                    "FT" => altValue * 0.3048,
                    _ => altValue
                };
            }

            return value;
        }

        private static string ConvertDecimalToDms(LatLonAlt _value)
        {
            string dms = string.Empty;
            double lat = Math.Abs(_value.m_Latitude);
            char latHemis = _value.m_Latitude >= 0.0 ? 'N' : 'S';

            int latDegree = (int)lat;
            double latMinutes = (lat - latDegree) * 60.0;
            double latDms = (latDegree * 100) + latMinutes;

            dms += latDms.ToString("0.0000");
            dms += ',' + latHemis.ToString() + ',';

            double lon = Math.Abs(_value.m_Longitude);
            char lonHemis = _value.m_Longitude >= 0.0 ? 'E' : 'W';

            int lonDegree = (int)lon;
            double lonMinutes = (lon - lonDegree) * 60.0;
            double lonDms = (lonDegree * 100) + lonMinutes;

            dms += lonDms.ToString("0.0000");
            dms += ',' + lonHemis.ToString() + ',';

            return dms;
        }

        public static bool operator ==(GPGGA _a, GPGGA _b)
        {
            if (ReferenceEquals(_a, _b))
                return true;
            if (_a is null || _b is null)
                return false;

            return _a.m_Coordinates == _b.m_Coordinates;
        }

        public static bool operator !=(GPGGA _a, GPGGA _b)
        {
            return !(_a == _b);
        }
    }
}
