//using System.IO;
//using System.Net.Sockets;
//using System.Text;

//namespace RtcmSharp.RtcmNetwork
//{
//    public class RtcmSocket
//    {
//        private string m_Host { get; set; }
//        private int m_Port { get; set; }
//        public TcpClient m_Client { get; set; }
//        public NetworkStream? m_Stream { get; set; }
//        public StreamWriter? m_Writer { get; set; }

//        public RtcmSocket(string _host, int _port)
//        {
//            m_Host = _host;
//            m_Port = _port;
//            m_Client = new TcpClient();
//        }

//        public async Task<bool> Connect()
//        {
//            try
//            {
//                await m_Client.ConnectAsync(m_Host, m_Port);

//                m_Stream = m_Client.GetStream();
//                m_Writer = new StreamWriter(m_Stream, Encoding.ASCII, 4096, leaveOpen: true) { AutoFlush = true };

//                return true;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Initialise failed: {ex.Message}");
//                return false;
//            }
//        }

//        public async Task<bool> SendAsync(string _request)
//        {
//            if (m_Writer == null)
//                return false;

//            try
//            {
//                await m_Writer.WriteAsync(_request);
//                return true;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Send failed: {ex.Message}");
//                return false;
//            }
//        }

//        public async Task<(bool success, byte[] data)> ReceiveAsync()
//        {
//            try
//            {
//                var buffer = new byte[4096];
//                int bytesRead = await m_Stream.ReadAsync(buffer, 0, buffer.Length);

//                if (bytesRead == 0)
//                    return (false, Array.Empty<byte>());

//                var result = new byte[bytesRead];
//                Array.Copy(buffer, result, bytesRead);
//                return (true, result);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"ReceiveAsync failed: {ex.Message}");
//                return (false, Array.Empty<byte>());
//            }
//        }

//        public void Disconnect()
//        {
//            var results = ReceiveAsync();
//            Dispose();
//            m_Stream = null;
//            m_Client = new TcpClient();
//        }

//        public void Dispose()
//        {
//            m_Stream?.Dispose();
//            m_Client?.Close();
//        }
//    }
//}
