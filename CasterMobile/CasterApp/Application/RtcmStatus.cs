using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using RtcmSharp;
using RtcmSharp.RtcmNetwork;

namespace CasterApp.Application
{
    public static class RtcmStatus
    {
        public static RtcmTcpSocket? m_RtcmSocket;
        public static RtcmParser? m_RtcmParser;
        public static CancellationTokenSource? m_Token;
        public static MountpointStatus? m_MountpointStatus;
        public static MountpointData? m_SelectedMountpoint;
        public static event Action<bool>? m_OnMessageReceived;
        public static void Init(MountpointData _mountpoint)
        {
            m_RtcmSocket = new RtcmTcpSocket(ConnectionInfo.m_Host, ConnectionInfo.m_Port, 4096);
            m_RtcmParser = new();
            m_Token = new();
            m_SelectedMountpoint = _mountpoint;
            m_MountpointStatus = new MountpointStatus(m_SelectedMountpoint);
        }

        public static void Cleanup()
        {

        }

        public static async Task StreamAsync()
        {
            await m_RtcmSocket.ConnectAsync();
            await m_RtcmSocket.SendAsync(ConnectionInfo.GetRequest(m_MountpointStatus.m_Info.m_Mountpoint));

            while (!m_Token.IsCancellationRequested)
            {
                byte[]? result = await m_RtcmSocket.ReceiveAsync();
                if (result == null)
                    continue;
                foreach (byte b in result)
                {
                    if (m_RtcmParser.ParseByte(b))
                    {
                        RtcmPacket packet = m_RtcmParser.GetRtcmPacket();
                        int size = packet.m_Header.Length + packet.m_CRC.Length + packet.m_Payload.Count;
                        m_MountpointStatus.UpdateMessageStatus(packet.GetMessageType().ToString(), size);
                        m_OnMessageReceived?.Invoke(new bool());
                    }
                }
            }

            m_RtcmSocket.Dispose();
        }

        public static async Task StopStreamAsync()
        {
            if (m_Token != null)
            {
                m_Token.Cancel();
                m_Token.Dispose();
            }
        }
    }
}
