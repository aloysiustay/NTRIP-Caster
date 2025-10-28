using RtcmSharp.RtcmMessageTypes;
using RtcmSharp.RtcmNetwork;
using System.Collections.Concurrent;
using System.Runtime.InteropServices.JavaScript;

namespace RtcmSharp
{
    public class RtcmStreamer
    {
        //private string m_Mountpoint;
        private CancellationTokenSource? m_StreamToken = null;
        private CancellationTokenSource? m_DecodeToken = null;
        private Task? m_StreamTask = null;
        private Task? m_DecodeTask = null;

        public bool IsStreamActive => m_StreamToken != null ? true : false;
        public bool IsDecodeActive => m_DecodeToken != null ? true : false;
        public long m_ReadIndex = 0;
        public RtcmCircularBuffer m_Buffer { get; set; }
        public RtcmParser m_Parser { get; set; }

        public RtcmTcpSocket m_TcpSocket;
        //public ConcurrentDictionary<ushort, BaseMessage> m_Messages = new();
        public MountpointSessionInfo m_SessionInfo = new();

        public RtcmStreamer(string _host, int _port, string _mountpoint)
        {
            m_SessionInfo.m_Mountpoint = _mountpoint;
            m_Buffer = new RtcmCircularBuffer(512);
            m_Parser = new RtcmParser();
            m_TcpSocket = new RtcmTcpSocket(_host, _port, 4096);
        }
        public void Reintialise(string _host, int _port)
        {
            m_TcpSocket = new RtcmTcpSocket(_host, _port, 4096);
        }

        public void StartStream(string _request)
        {
            if (m_StreamToken != null)
                return;

            m_StreamToken = new CancellationTokenSource();
            m_StreamTask = Task.Run(() => StreamAsync(_request, m_StreamToken.Token));
        }
        public void StartDecode()
        {
            if (m_DecodeToken != null)
                return;

            m_DecodeToken = new CancellationTokenSource();
            m_DecodeTask = Task.Run(() => DecodeAsync(m_DecodeToken.Token));
        }
        public async Task Dispose()
        {
            await StopStreamAsync();
        }
        public async Task DecodeAsync(CancellationToken _token)
        {
            if (m_StreamToken == null)
                return;

            RtcmPacket packet = new RtcmPacket();
            while(!_token.IsCancellationRequested)
            {
                if(m_Buffer.Read(ref m_ReadIndex, out packet))
                {
                    BaseMessage? message = RtcmUtils.ProcessMessage(packet);
                    if(message != null)
                    {
                        MessageSessionInfo info = m_SessionInfo.m_Messages[message.m_MessageType.GetRawValue()];
                        info.m_Message = message;
                        ++info.m_MessageCount;
                    }
                }
                else
                {
                    await Task.Delay(5, _token);
                }
            }
        }

        public async Task StreamAsync(string _request, CancellationToken _token)
        {
            await m_TcpSocket.ConnectAsync();
            await m_TcpSocket.SendAsync(_request);

            while (!_token.IsCancellationRequested)
            {
                byte[]? result = await m_TcpSocket.ReceiveAsync();
                if (result == null)
                    continue;
                foreach (byte b in result)
                {
                    if (m_Parser.ParseByte(b))
                        m_Buffer.Write(m_Parser.GetRtcmPacket());
                }
            }

            m_TcpSocket.Dispose();
        }

        public async Task StopStreamAsync()
        {
            if (m_StreamToken != null)
            {
                m_StreamToken.Cancel();
                if (m_StreamTask != null)
                    await m_StreamTask;

                m_StreamToken.Dispose();
                m_StreamToken = null;
                m_StreamTask = null;
            }
            await StopDecodingAsync();
        }

        public async Task StopDecodingAsync()
        {
            if (m_DecodeToken != null)
            {
                m_DecodeToken.Cancel();
                if (m_DecodeTask != null)
                    await m_DecodeTask;

                m_DecodeToken.Dispose();
                m_DecodeToken = null;
                m_DecodeTask = null;
            }
        }
    }
}
