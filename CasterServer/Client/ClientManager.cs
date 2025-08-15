using System.Net.Sockets;
using CasterServer.Mountpoint;
using RtcmSharp.RtcmNetwork;
using Microsoft.AspNetCore.Http;

namespace CasterServer.Client
{
    public class ClientManager
    {
        private readonly MountpointManager m_MountpointManager;
        private readonly RtcmTcpListener m_Listener;
        private readonly List<ClientSession> m_Sessions = new();

        CancellationTokenSource m_CancellationToken = new CancellationTokenSource();
        public ClientManager(int _port, MountpointManager _mountpointManager) 
        {
            m_MountpointManager = _mountpointManager;
            m_Listener = new RtcmTcpListener(_port);
        }
        public async Task StartAsync()
        {
            Console.WriteLine("NTRIP server listening...");

            while (!m_CancellationToken.Token.IsCancellationRequested)
            {
                var client = await m_Listener.AcceptTcpClientAsync();
                var session = new ClientSession(client, RemoveSession, m_MountpointManager);

                lock (m_Sessions)
                    m_Sessions.Add(session);

                Console.WriteLine($"Client connected. Active: {m_Sessions.Count}");

                _ = session.StartAsync();

            }
        }
        private void RemoveSession(ClientSession _session)
        {
            lock (_session)
                m_Sessions.Remove(_session);

            Console.WriteLine($"Client removed. Active: {m_Sessions.Count}");
        }
        public void Dispose()
        {
            m_CancellationToken.Cancel();
            foreach(ClientSession session in m_Sessions)
            {
                session.Dispose();
            }
        }
    }
}
