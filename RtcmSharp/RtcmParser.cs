namespace RtcmSharp
{
    internal enum ParseState
    {
        WAIT_PREAMBLE,
        READ_HEADER,
        READ_PAYLOAD,
        READ_CRC
    }
    public class RtcmParser
    {
        private RtcmPacket m_Packet = new RtcmPacket();
        private ParseState m_State = ParseState.WAIT_PREAMBLE;
        private int m_BytesRead = 0;
        private int m_PayloadLength = 0;
        private bool m_PayloadReceived = false;
        public RtcmPacket GetRtcmPacket()
        {
            return m_Packet;
        }
        public bool ParseByte(byte _inputByte)
        {
            m_PayloadReceived = false;

            switch (m_State)
            {
                case ParseState.WAIT_PREAMBLE:
                    if (_inputByte == 0xD3)
                    {
                        Reset();
                        m_Packet.m_Header[0] = _inputByte;
                        m_State = ParseState.READ_HEADER;
                        m_BytesRead = 1;
                    }
                    break;

                case ParseState.READ_HEADER:
                    m_Packet.m_Header[m_BytesRead++] = _inputByte;
                    if (m_BytesRead == 3)
                    {
                        m_PayloadLength = ((m_Packet.m_Header[1] & 0x03) << 8) | m_Packet.m_Header[2];
                        m_State = ParseState.READ_PAYLOAD;
                        m_Packet.m_Payload.Capacity = m_PayloadLength;
                        m_BytesRead = 0;
                    }
                    break;

                case ParseState.READ_PAYLOAD:
                    m_Packet.m_Payload.Add(_inputByte);
                    if (++m_BytesRead == m_PayloadLength)
                    {
                        m_State = ParseState.READ_CRC;
                        m_BytesRead = 0;
                    }
                    break;

                case ParseState.READ_CRC:
                    m_Packet.m_CRC[m_BytesRead++] = _inputByte;
                    if (m_BytesRead == 3)
                    {
                        if (ValidateCRC())
                        {
                            m_PayloadReceived = true;
                        }
                        else
                        {
                            Console.WriteLine("CRC error");
                        }
                        m_State = ParseState.WAIT_PREAMBLE;
                    }
                    break;
            }

            return m_PayloadReceived;
        }
        private void Reset()
        {
            m_Packet = new RtcmPacket();
            m_BytesRead = 0;
            m_PayloadLength = 0;
        }
        private bool ValidateCRC()
        {
            List<byte> package = new List<byte>
            {
                m_Packet.m_Header[0],
                m_Packet.m_Header[1],
                m_Packet.m_Header[2]
            };
            package.AddRange(m_Packet.m_Payload);

            uint computedCRC = RtcmUtils.CRC24Q(package);
            uint receivedCRC = (uint)((m_Packet.m_CRC[0] << 16) | (m_Packet.m_CRC[1] << 8) | m_Packet.m_CRC[2]);

            return computedCRC == receivedCRC;
        }

    }
}