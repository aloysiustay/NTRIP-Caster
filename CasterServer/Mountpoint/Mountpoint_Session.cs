using RtcmSharp;
using CasterServer.Network;
using RtcmSharp.RtcmMessageTypes;

namespace CasterServer.Mountpoint
{
    public class MountpointSession
    {
        public string m_Host { get; set; }
        public int m_Port { get; set; }
        public MountpointData m_Info { get; set; }
        public RtcmStreamer m_Streamer;
        public int m_NumClientConnected = 0;
        public MountpointSession(MountpointData _data)
        {
            m_Host = _data.m_Host;
            m_Port = _data.m_Port;
            m_Info = _data;
            m_Streamer = new RtcmStreamer(m_Host, m_Port, m_Info.m_Mountpoint);
        }
        public void RegisterClient()
        {
            ++m_NumClientConnected;
            Console.WriteLine($"Number of Registered Clients for {m_Info.m_Mountpoint}: {m_NumClientConnected}");
        }
        public async void UnregisterClient()
        {
            //mutex
            if (m_NumClientConnected <= 0)
                return;

            --m_NumClientConnected;
            if(m_NumClientConnected <= 0)
            {
                Console.WriteLine($"Session stopped for {m_Info.m_Mountpoint}");
                await m_Streamer.Dispose();
                m_Streamer.Reintialise(m_Host, m_Port);
            }
        }
        public bool StreamRTCM()
        {
            if (m_Streamer.IsStreamActive)
                return false;

            Console.WriteLine($"Session started for {m_Info.m_Mountpoint}");
            m_Streamer.StartStream(NetworkUtils.FormatMountpointRequest("aloytaytay-at-gmail.com:password", m_Info.m_Mountpoint));
            return true;
        }

        public void DecodeRTCM()
        {
            m_Streamer.StartDecode();
        }

        public void PrintMessages()
        {
            //Console.WriteLine("====================================");
            //Console.WriteLine(m_Streamer.m_Messages.Count.ToString());
            //foreach (var msg in m_Streamer.m_Messages)
            //{
            //    //Console.WriteLine(msg.Key.ToString());
            //    Console.WriteLine(msg.Value.Describe(true));
            //}
        }

        public async void Dispose()
        {
            await m_Streamer.Dispose();
        }
    }
}
