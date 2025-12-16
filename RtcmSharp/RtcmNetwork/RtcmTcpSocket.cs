using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RtcmSharp.RtcmNetwork
{
    public class RtcmTcpSocket
    {
        public string m_Host;
        public int m_Port;
        protected Socket m_Socket;
        protected byte[] m_Buffer;
        private StringBuilder m_LineBuffer = new StringBuilder();
        private bool m_Disposed;
        public RtcmTcpSocket(string _host, int _port, int _bufferSize)
        {
            m_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_Buffer = new byte[_bufferSize];
            m_Host = _host;
            m_Port = _port;
        }
        public RtcmTcpSocket(Socket _socket, int _bufferSize)
        {
            m_Socket = _socket;
            m_Buffer = new byte[_bufferSize];

            var remoteEndPoint = m_Socket.RemoteEndPoint as IPEndPoint;
            if (remoteEndPoint != null)
            {
                m_Host = remoteEndPoint.Address.ToString();
                m_Port = remoteEndPoint.Port;
            }
            else
            {
                m_Host = string.Empty;
                m_Port = 0;
            }
        }

        public bool IsConnected
        {
            get
            {
                if (m_Socket == null)
                    return false;

                try
                {
                    return !(m_Socket.Poll(1, SelectMode.SelectRead) && m_Socket.Available == 0);
                }
                catch (SocketException)
                {
                    return false;
                }
            }
        }

        public async Task<bool> ConnectAsync()
        {
            try
            {
                await m_Socket.ConnectAsync(m_Host, m_Port);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> SendAsync(string _message)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(_message);
            return await SendAsync(bytes);
        }

        public async Task<bool> SendAsync(byte[] _data)
        {
            if (m_Disposed)
                return false;
            try
            {
                int totalSent = 0;
                while (totalSent < _data.Length)
                {
                    int sent = await m_Socket.SendAsync(new ArraySegment<byte>(_data, totalSent, _data.Length - totalSent),SocketFlags.None);

                    if (sent == 0)
                        return false;

                    totalSent += sent;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Send failed: {ex.Message}");
                return false;
            }
        }

        public async Task<byte[]?> ReceiveAsync()
        {
            if (m_Disposed)
                return null;

            try
            {
                int bytesRead = await m_Socket.ReceiveAsync(m_Buffer, SocketFlags.None);

                if (bytesRead == 0) 
                    return null;

                var result = new byte[bytesRead];
                Array.Copy(m_Buffer, result, bytesRead);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Receive failed: {ex.Message}");
                return null;
            }
        }

        public async Task<string?> ReceiveLineAsync()
        {
            while(true)
            {
                int newlineIndex = m_LineBuffer.ToString().IndexOf('\n');
                if (newlineIndex >= 0)
                {
                    string line = m_LineBuffer.ToString(0, newlineIndex).TrimEnd('\r');
                    m_LineBuffer.Remove(0, newlineIndex + 1);
                    return line;
                }

                byte[]? bytes = await ReceiveAsync();
                if (bytes == null)
                    return null;

                string received = Encoding.ASCII.GetString(bytes);
                m_LineBuffer.Append(received);
            }
        }
        public void Close()
        {
            try
            {
                if (m_Socket?.Connected == true)
                    m_Socket.Shutdown(SocketShutdown.Both);
            }
            catch { /* Ignore */ }
            finally
            {
                m_Socket?.Close();
                m_Socket = null!;
            }
        }
        public void Dispose()
        {
            if (m_Disposed)
                return;

            Close();
            m_Buffer = null!;
            m_LineBuffer.Clear();
            m_Disposed = true;
            GC.SuppressFinalize(this);
        }
    }

}
