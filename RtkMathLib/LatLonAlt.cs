using System.Security.Cryptography;

namespace RtkMathLib
{
    public struct LatLonAlt
    {
        public double m_Latitude { get; set; }
        public double m_Longitude { get; set; }
        public double m_Altitude { get; set; }
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

        public LatLonAlt(ECEF _ecef, double _tolerance = 1e-12, int _maxIter = 10)
        {
            double lon = Math.Atan2(_ecef.m_Y, _ecef.m_X);
            double p = Math.Sqrt(_ecef.m_X * _ecef.m_X + _ecef.m_Y * _ecef.m_Y);

            // Handle pole
            if (p < 1e-12)
            {
                double latPole = Math.Sign(_ecef.m_Z) * Math.PI / 2.0;
                double b = ECEF.a * (1 - ECEF.f);
                double hPole = Math.Abs(_ecef.m_Z) - b;
                m_Latitude = Utils.RadToDeg(latPole);
                m_Longitude = Utils.RadToDeg(lon);
                m_Altitude = hPole;
            }

            double lat = Math.Atan2(_ecef.m_Z, p * (1.0 - ECEF.e2));

            for (int i = 0; i < _maxIter; i++)
            {
                double sinLat = Math.Sin(lat);
                double N = ECEF.a / Math.Sqrt(1 - ECEF.e2 * sinLat * sinLat);
                double h = p / Math.Cos(lat) - N;

                double latNew = Math.Atan2(_ecef.m_Z, p * (1 - ECEF.e2 * (N / (N + h))));

                if (Math.Abs(latNew - lat) < _tolerance)
                {
                    lat = latNew;
                    break;
                }
                lat = latNew;
            }

            double sinLatF = Math.Sin(lat);
            double Nf = ECEF.a / Math.Sqrt(1 - ECEF.e2 * sinLatF * sinLatF);
            double hF = p / Math.Cos(lat) - Nf;

            m_Latitude = Utils.RadToDeg(lat);
            m_Longitude = Utils.RadToDeg(lon);
            m_Altitude = hF;
        }

        public static bool operator ==(LatLonAlt _a, LatLonAlt _b)
        {
            return _a.m_Latitude == _b.m_Latitude && _a.m_Longitude == _b.m_Longitude && _a.m_Altitude == _b.m_Altitude;
        }
        public static bool operator !=(LatLonAlt _a, LatLonAlt _b)
        {
            return !(_a == _b);
        }

        //public ECEF ConvertToECEF()
        //{
        //    double lat = m_Latitude * Math.PI / 180.0;
        //    double lon = m_Longitude * Math.PI / 180.0;

        //    double sinLat = Math.Sin(lat);
        //    double cosLat = Math.Cos(lat);
        //    double sinLon = Math.Sin(lon);
        //    double cosLon = Math.Cos(lon);

        //    double N = a / Math.Sqrt(1.0 - e2 * sinLat * sinLat);

        //    double x = (N + m_Altitude) * cosLat * cosLon;
        //    double y = (N + m_Altitude) * cosLat * sinLon;
        //    double z = (N * (1.0 - e2) + m_Altitude) * sinLat;

        //    return new ECEF(x, y, z);
        //}
    }
}
