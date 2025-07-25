using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtcmSharp.RtcmDatafields;

namespace RtcmSharp
{
    internal class BitstreamUtils
    {
        public static bool CheckBit64MSB(ulong _mask, int _bitIndex)
        {
            return ((_mask >> (63 - _bitIndex)) & 1) == 1;
        }

        public static bool CheckBit32MSB(uint _mask, int _bitIndex)
        {
            return ((_mask >> (31 - _bitIndex)) & 1) == 1;
        }

        public static bool CheckBitLSB(ulong _mask, int _bitIndex)
        {
            return ((_mask >> _bitIndex) & 1) == 1;
        }

        public static int CountBits(ulong _val)
        {
            int count = 0;
            while (_val != 0)
            {
                count += (int)(_val & 1);
                _val >>= 1;
            }
            return count;
        }
    }
}
