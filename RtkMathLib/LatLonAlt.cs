namespace RtkMathLib
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
}
