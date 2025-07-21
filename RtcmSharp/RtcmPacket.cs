using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtcmSharp
{
    internal class RtcmPacket
    {
        // 3-byte header
        public byte[] Header { get; set; } = new byte[3];

        // Payload bytes (dynamic size)
        public List<byte> Payload { get; set; } = new List<byte>();

        // 3-byte CRC
        public byte[] CRC { get; set; } = new byte[3];

        // Return the full packet as a byte array
        public byte[] GetFullPacket()
        {
            var combined = new byte[Header.Length + Payload.Count + CRC.Length];
            Buffer.BlockCopy(Header, 0, combined, 0, Header.Length);
            Payload.CopyTo(combined, Header.Length);
            Buffer.BlockCopy(CRC, 0, combined, Header.Length + Payload.Count, CRC.Length);
            return combined;
        }
    }
}
