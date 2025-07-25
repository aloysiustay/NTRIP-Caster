using System;
using System.Collections;
using System.Collections.Generic;

namespace RtcmSharp.Bit
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
                int bitOffset = 7 - m_BitPos % 8;
                if (bytePos >= m_Data.Length)
                    throw new IndexOutOfRangeException("Bitstream overread");

                value = value << 1 | (ulong)(m_Data[bytePos] >> bitOffset & 1);
                m_BitPos++;
            }

            return value;
        }

        public long ReadBitsTwosComplement(int _numBits)
        {
            ulong value = ReadBitsUnsigned(_numBits);
            if ((value & 1UL << _numBits - 1) != 0)
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

        public ulong SeekBitsUnsigned(int _bitPos, int _numBits)
        {
            if (_numBits < 0 || _numBits > 64)
                throw new ArgumentOutOfRangeException(nameof(_numBits), "Must be between 0 and 64");

            ulong value = 0;
            int bitPos = m_BitPos + _bitPos;
            for (int i = 0; i < _numBits; ++i)
            {
                int bytePos = bitPos / 8;
                int bitOffset = 7 - bitPos % 8;
                if (bytePos >= m_Data.Length)
                    throw new IndexOutOfRangeException("Bitstream overread");

                value = value << 1 | (ulong)(m_Data[bytePos] >> bitOffset & 1);
                bitPos++;
            }

            return value;
        }

        public long SeekBitsTwosComplement(int _bitPos, int _numBits)
        {
            ulong value = SeekBitsUnsigned(_bitPos, _numBits);
            if ((value & 1UL << _numBits - 1) != 0)
            {
                // Sign bit is set → perform sign extension
                value |= ~((1UL << _numBits) - 1);
            }

            return unchecked((long)value);
        }

        public long SeekBitsSignMagnitude(int _bitPos, int _numBits)
        {
            bool isNegative = SeekBitsUnsigned(_bitPos, 1) != 0;
            ulong magnitude = SeekBitsUnsigned(_bitPos + 1, _numBits - 1);
            long result = (long)magnitude;
            return isNegative ? -result : result;
        }
        public void SeekAndSet(int _numBits)
        {
            m_BitPos += _numBits;
        }
        public void Reset()
        {
            m_BitPos = 0;
        }

        public void DumpRemainingBitsAsText(string filePath)
        {
            int totalBits = m_Data.Length * 8;
            int remainingBits = totalBits - m_BitPos;

            if (remainingBits <= 0)
                return;

            using (var writer = new StreamWriter(filePath))
            {
                for (int i = m_BitPos; i < totalBits; ++i)
                {
                    int bytePos = i / 8;
                    int bitOffset = 7 - (i % 8);
                    if (bytePos >= m_Data.Length)
                        break;

                    int bit = (m_Data[bytePos] >> bitOffset) & 1;
                    writer.Write(bit);
                }
            }
        }
        public void DumpRemainingBitsToFile(string filePath)
        {
            int totalBits = m_Data.Length * 8;
            int remainingBits = totalBits - m_BitPos;

            if (remainingBits <= 0)
                return;

            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                int bitsToWrite = remainingBits;
                int currentBitPos = m_BitPos;
                byte currentByte = 0;
                int bitIndex = 0;

                while (bitsToWrite > 0)
                {
                    int bytePos = currentBitPos / 8;
                    int bitOffset = 7 - (currentBitPos % 8);
                    byte bit = (byte)((m_Data[bytePos] >> bitOffset) & 1);

                    currentByte = (byte)((currentByte << 1) | bit);
                    bitIndex++;
                    currentBitPos++;
                    bitsToWrite--;

                    if (bitIndex == 8 || bitsToWrite == 0)
                    {
                        // Pad remaining bits with 0s if not full byte
                        if (bitIndex < 8)
                            currentByte <<= (8 - bitIndex);

                        fs.WriteByte(currentByte);
                        currentByte = 0;
                        bitIndex = 0;
                    }
                }
            }
        }
    }
}
