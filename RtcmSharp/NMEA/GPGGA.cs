using System.Globalization;
using RtkMathLib;

namespace RtcmSharp.NMEA
{
    public class GPGGA
    {
        public string m_UtcTime { get; set; } = string.Empty;
        public LatLonAlt m_Coordinates { get; set; }
        public double m_GeoidHeight { get; set; }
        public int m_FixQuality { get; set; }
        public int m_NumSatellites { get; set; }
        public double m_HorizontalDilutionOfPrecision { get; set; }
        public int m_AgeOfCorrectionData { get; set; }
        public int m_DiffStationId { get; set; }
        public string m_RawString { get; set; } = string.Empty;

        public static bool TryParse(string _string, out GPGGA _data)
        {
            _data = new GPGGA();

            if (!ValidateChecksum(_string))
                return false;

            var parts = _string.Split(',');

            if (parts.Length < 14 || parts[0] != "$GPGGA")
                return false;

            _data.m_RawString = _string;

            _data.m_UtcTime = parts[1];
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

            if (Int32.TryParse(last[0], out int _id))
                _data.m_DiffStationId = _id;

            return true;
        }

        private static bool ValidateChecksum(string _sentence)
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
    }
}
