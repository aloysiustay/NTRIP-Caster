using System.Net;
using System.Net.Sockets;

namespace RtcmSharp.RtcmNetwork
{
    public class RtcmTcpListener
    {
        private Socket m_ListenerSocket;

        public RtcmTcpListener(int _port, string? _host = null)
        {
            var ipAddress = _host == null ? IPAddress.Any : IPAddress.Parse(_host);
            m_ListenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_ListenerSocket.Bind(new IPEndPoint(ipAddress, _port));
            m_ListenerSocket.Listen(100);
        }
        public async Task<RtcmTcpSocket> AcceptTcpClientAsync()
        {
            Socket client = await m_ListenerSocket.AcceptAsync();
            return new RtcmTcpSocket(client, 4096);
        }
    }
}