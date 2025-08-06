using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtcmSharp;

namespace RtcmSharp
{
    public class RtcmPacket
    {
        // 3-byte header
        public byte[] m_Header { get; set; } = new byte[3];

        // Payload bytes (dynamic size)
        public List<byte> m_Payload { get; set; } = new List<byte>();

        // 3-byte CRC
        public byte[] m_CRC { get; set; } = new byte[3];

        public DateTimeOffset m_TimeStamp; 
        public ushort GetMessageType()
        {
            byte first = m_Payload[0];
            byte second = m_Payload[1];
            ushort combined = (ushort)((first << 8) | second);
            return (ushort)(combined >> 4);
        }

        // Return the full packet as a byte array
        public byte[] GetFullPacket()
        {
            var combined = new byte[m_Header.Length + m_Payload.Count + m_CRC.Length];
            Buffer.BlockCopy(m_Header, 0, combined, 0, m_Header.Length);
            m_Payload.CopyTo(combined, m_Header.Length);
            Buffer.BlockCopy(m_CRC, 0, combined, m_Header.Length + m_Payload.Count, m_CRC.Length);
            return combined;
        }
    }
}
