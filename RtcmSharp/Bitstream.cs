using System;
using System.Collections.Generic;

namespace Caster.Parser
{
    public class Bitstream
    {
        private readonly byte[] m_Data;
        private int m_BitPos;

        public Bitstream(byte[] _data)
        {
            m_Data = _data ?? throw new ArgumentNullException(nameof(_data));
            m_BitPos = 0;
        }

        public ulong ReadBitsUnsigned(int _numBits)
        {
            if (_numBits < 0 || _numBits > 64)
                throw new ArgumentOutOfRangeException(nameof(_numBits), "Must be between 0 and 64");

            ulong value = 0;

            for (int i = 0; i < _numBits; ++i)
            {
                int bytePos = m_BitPos / 8;
                int bitOffset = 7 - (m_BitPos % 8);
                if (bytePos >= m_Data.Length)
                    throw new IndexOutOfRangeException("Bitstream overread");

                value = (value << 1) | (ulong)((m_Data[bytePos] >> bitOffset) & 1);
                m_BitPos++;
            }

            return value;
        }

        public long ReadBitsTwosComplement(int _numBits)
        {
            ulong value = ReadBitsUnsigned(_numBits);
            if ((value & (1UL << (_numBits - 1))) != 0)
            {
                // Sign bit is set → perform sign extension
                value |= ~((1UL << _numBits) - 1);
            }

            return unchecked((long)value);
        }

        public long ReadBitsSignMagnitude(int _numBits)
        {
            bool isNegative = ReadBitsUnsigned(1) != 0;
            ulong magnitude = ReadBitsUnsigned(_numBits - 1);
            long result = (long)magnitude;
            return isNegative ? -result : result;
        }

        public void Seek(int _bits)
        {
            m_BitPos += _bits;
        }
    }
}
