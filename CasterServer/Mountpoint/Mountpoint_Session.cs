using RtcmSharp;
using CasterServer.Network;
using RtcmSharp.RtcmMessageTypes;

namespace CasterServer.Mountpoint
{
    public class MountpointSession
    {
        private string m_Host { get; set; }
        private int m_Port { get; set; }
        public MountpointData m_Info { get; set; }
        public RtcmStreamer m_Streamer;
        public MountpointSession(MountpointData _data)
        {
            m_Host = _data.m_Host;
            m_Port = _data.m_Port;
            m_Info = _data;
            m_Streamer = new RtcmStreamer(m_Host, m_Port, m_Info.m_Mountpoint);
        }
        public void StreamRTCM()
        {
            m_Streamer.StartStream(NetworkUtils.FormatMountpointRequest("aloytaytay-at-gmail.com:password", m_Info.m_Mountpoint));
        }

        public void DecodeRTCM()
        {
            m_Streamer.StartDecode();
        }

        public void PrintMessages()
        {
            Console.WriteLine("====================================");
            Console.WriteLine(m_Streamer.m_Messages.Count.ToString());
            foreach (var msg in m_Streamer.m_Messages)
            {
                //Console.WriteLine(msg.Key.ToString());
                Console.WriteLine(msg.Value.Describe(true));
            }
        }

        public async void Dispose()
        {
            await m_Streamer.Dispose();
        }
    }
}
