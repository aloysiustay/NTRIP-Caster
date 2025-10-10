using System.Security.Cryptography;
using CasterServer.Clock;

namespace CasterApp.Application
{
    public class SatelliteInfo
    {
        public int m_SatelliteID = 0;
        public string m_Frequencies = string.Empty;
        public float m_SignalToNoiseRatio = 0;
    };

    public class MessageInfo
    {
        public int m_Count = 0;
        public DateTimeOffset m_LastReceived;
        public TimeSpan m_Periodicity;
    };

    public class MountpointStatus
    {
        public MountpointData m_Info;
        public Dictionary<string, MessageInfo> m_MessageStatus;
        public Dictionary<string, List<SatelliteInfo>> m_Satellites;
        public MountpointStatus(MountpointData _mountpoint)
        {
            m_Info = _mountpoint;
            m_MessageStatus = new();
            m_Satellites = new();
            Init();
        }
        public void Init()
        {
            var messageTypes = m_Info.m_FormatDetails
            .Split(',')
            .Select(s => s.Split('(')[0]) // take the part before '('
            .ToList();

            foreach (var messageType in messageTypes)
            {
                m_MessageStatus.TryAdd(messageType, new MessageInfo());
            }
        }
        public void UpdateMessageStatus(string _messageType, int _messageSize)
        {
            MessageInfo info = m_MessageStatus[_messageType];
            ++info.m_Count;
            DateTimeOffset currentTime = RtcmClock.GetUtcTime();
            info.m_Periodicity = currentTime - info.m_LastReceived;
            info.m_LastReceived = currentTime;
        }
    };
}
