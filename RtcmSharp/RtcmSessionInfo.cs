using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtcmSharp.RtcmMessageTypes;

namespace RtcmSharp
{
    public class MountpointSessionInfo
    {
        public string m_Mountpoint = string.Empty;
        public ConcurrentDictionary<ushort, MessageSessionInfo> m_Messages = new();

        public int GetTotalMessageCount()
        {
            int ret = 0;
            foreach(var info in m_Messages)
            {
                ret += info.Value.m_MessageCount;
            }
            return ret;
        }
    }

    public class MessageSessionInfo
    {
        public int m_MessageCount = 0;
        public BaseMessage? m_Message;
    }
}
