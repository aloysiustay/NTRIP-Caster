using RtcmSharp;

namespace CasterServer.Mountpoint
{
    public class MountpointSession
    {
        private string m_Host;
        private int m_Port;
        public bool m_IsStreaming = false;
        public CircularRTCMBuffer m_Buffer = new CircularRTCMBuffer(512);
        public Network.Socket m_Socket;
        public MountpointData m_Info;
        public RtcmParser m_Parser;

        public MountpointSession(MountpointData _data)
        {
            m_Host = _data.m_Host;
            m_Port = _data.m_Port;
            m_Info = _data;
            m_Socket = new Network.Socket(m_Host, m_Port);
        }
        public async Task StreamRTCM()
        {
            m_IsStreaming = true;

            string request = Network.NetworkUtils.FormatMountpointRequest("aloytaytay-at-gmail.com:password", m_Info.m_Mountpoint);
            await m_Socket.Connect();
            await m_Socket.SendAsync(request);

            while (m_IsStreaming)
            {
                var result = await m_Socket.ReceiveAsync();
                if (!result.success)
                    continue;
                foreach (byte b in result.data)
                {
                    if (m_Parser.ParseByte(b))
                        m_Buffer.Write(m_Parser.GetRtcmPacket());
                }
            }

            m_Socket.Disconnect();
        }
        public void StopStream()
        {
            m_IsStreaming = false;
        }

    }
}
