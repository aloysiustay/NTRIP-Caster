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
