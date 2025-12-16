using System;

namespace RtkMathLib
{
    public static class Utils
    {
        public static double RadToDeg(double _rad) => _rad * (180.0 / Math.PI);
        public static double DegToRad(double _deg) => _deg * (Math.PI / 180.0);

        public static double HaversineDistance(LatLonAlt _a, LatLonAlt _b)
        {
            double lat1 = DegToRad(_a.m_Latitude);
            double lat2 = DegToRad(_b.m_Latitude);
            double dLat = DegToRad(_b.m_Latitude - _a.m_Latitude);
            double dLon = DegToRad(_b.m_Longitude - _a.m_Longitude);

            double h = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(h), Math.Sqrt(1 - h));

            return Constants.EARTH_RADIUS_M * c;
        }
    }
}
