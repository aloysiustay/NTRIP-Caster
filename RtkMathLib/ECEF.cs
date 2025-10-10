using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtkMathLib
{
    public struct ECEF
    {
        private const double a = 6378137.0;                     
        private const double f = 1.0 / 298.257223563;           
        private const double e2 = f * (2.0 - f);

        public double m_X { get; }
        public double m_Y { get; }
        public double m_Z { get; }

        public ECEF(double _x, double _y, double _z)
        {
            m_X = _x; m_Y = _y; m_Z = _z;
        }
    }
}
