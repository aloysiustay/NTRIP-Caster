using RtcmSharp;

namespace RtcmSharp
{
    public struct RtcmBufferStatus
    {
        public DateTimeOffset m_TimeStamp { get; set; }
        public TimeSpan m_TimeInterval { get; set; }
    }

    public class RtcmCircularBuffer
    {
        private readonly int m_Capacity;
        private readonly RtcmPacket[] m_Buffer;
        private readonly ReaderWriterLockSlim m_StatusLock = new();
        private readonly Dictionary<ushort, RtcmBufferStatus> m_Status = new();
        private readonly object m_Lock = new object();
        private long m_Head; // Use long for atomic operations

        public RtcmCircularBuffer(int _capacity)
        {
            m_Capacity = _capacity;
            m_Buffer = new RtcmPacket[_capacity];
            m_Head = 0;
        }
        private void UpdateStatus(RtcmPacket _packet)
        {
            ushort msgType = _packet.GetMessageType();
            RtcmBufferStatus status;

            m_StatusLock.EnterWriteLock();
            try
            {
                if (m_Status.TryGetValue(msgType, out status))
                {
                    status.m_TimeInterval = _packet.m_TimeStamp - status.m_TimeStamp;
                }
                else
                {
                    status = new RtcmBufferStatus
                    {
                        m_TimeInterval = TimeSpan.Zero
                    };
                }

                status.m_TimeStamp = _packet.m_TimeStamp;
                m_Status[msgType] = status;
            }
            finally
            {
                m_StatusLock.ExitWriteLock();
            }
        }
        public bool TryGetStatusSnapshot(out Dictionary<ushort, RtcmBufferStatus> _statusOut)
        {
            _statusOut = null!;

            m_StatusLock.EnterReadLock();
            try
            {
                _statusOut = new Dictionary<ushort, RtcmBufferStatus>(m_Status);
                return true;
            }
            finally
            {
                m_StatusLock.ExitReadLock();
            }
        }

        public void Write(RtcmPacket _packet)
        {
            if(_packet == null)
                return;

            int bufferIndex = (int)(m_Head % m_Capacity);
            m_Buffer[bufferIndex] = _packet;
            Interlocked.Increment(ref m_Head);
            UpdateStatus(_packet);
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
            //if (_outPacket == null)
            //{
            //    return false; 
            //}
            _readIndex++;
            return true;
        }
    }
}
