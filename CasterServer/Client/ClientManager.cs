using System.Net.Sockets;
using CasterServer.Mountpoint;
using RtcmSharp.RtcmNetwork;
using Microsoft.AspNetCore.Http;

namespace CasterServer.Client
{
    public class ClientManager
    {
        private readonly MountpointManager m_MountpointManager;
        private readonly List<ClientSession> m_Sessions = new();

        CancellationTokenSource m_CancellationToken = new CancellationTokenSource();
        public ClientManager(MountpointManager _mountpointManager) 
        {
            m_MountpointManager = _mountpointManager;
        }

        public void CreateSession(RtcmTcpSocket _client, string _mountpoint)
        {
            int numClients = m_Sessions.Count;
            var session = new ClientSession(++numClients, _client, RemoveSession, m_MountpointManager);

            lock (m_Sessions)
                m_Sessions.Add(session);

            Console.WriteLine($"Client connected. Active: {m_Sessions.Count}");

            _ = session.StartAsync(_mountpoint);
        }
        private void RemoveSession(ClientSession _session)
        {
            lock (_session)
                m_Sessions.Remove(_session);

            Console.WriteLine($"Active: {m_Sessions.Count}");
        }
        public void Dispose()
        {
            m_CancellationToken.Cancel();
            foreach(ClientSession session in m_Sessions)
            {
                session.Dispose();
            }
        }

        public List<SessionInfo> GetSessionInfo()
        {
            List<SessionInfo> info = new List<SessionInfo>();
            foreach(ClientSession sess in m_Sessions)
            {
                info.Add(sess.m_SessionInfo);
            }
            return info;
        }
    }
}
