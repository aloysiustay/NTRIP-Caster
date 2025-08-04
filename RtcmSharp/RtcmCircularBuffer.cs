using RtcmSharp;

namespace RtcmSharp
{
    public class RtcmCircularBuffer
    {
        private readonly int m_Capacity;
        private readonly RtcmPacket[] m_Buffer;
        private long m_Head; // Use long for atomic operations

        public RtcmCircularBuffer(int _capacity)
        {
            m_Capacity = _capacity;
            m_Buffer = new RtcmPacket[_capacity];
            m_Head = 0;
        }

        public void Write(RtcmPacket _packet)
        {
            long index = Interlocked.Increment(ref m_Head) - 1;
            int bufferIndex = (int)(index % m_Capacity);
            m_Buffer[bufferIndex] = _packet;
        }

        public long GetCurrentHead()
        {
            return Interlocked.Read(ref m_Head);
        }

        public bool Read(ref long _readIndex, out RtcmPacket _outPacket)
        {
            long head = Interlocked.Read(ref m_Head);

            if (head > _readIndex + m_Capacity)
            {
                // Reader fell too far behind, skip forward
                _readIndex = head;
                _outPacket = default!;
                return false;
            }

            if (_readIndex >= head)
            {
                // No new data
                _outPacket = default!;
                return false;
            }

            int bufferIndex = (int)(_readIndex % m_Capacity);
            _outPacket = m_Buffer[bufferIndex];
            _readIndex++;
            return true;
        }
    }
}
