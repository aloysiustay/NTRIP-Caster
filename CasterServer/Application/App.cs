using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasterServer.Mountpoint;
using CasterServer.GUI;
using CasterServer.Client;
using System.Threading;

namespace CasterServer.Application
{
    public class App
    {
        public MountpointManager m_MountpointManager;
        public ClientManager m_ClientManager;
        public CancellationTokenSource m_CancellationToken = new CancellationTokenSource();
        public WebGUI m_WebGUI;
        public App() 
        {
            m_MountpointManager = new MountpointManager();
            m_ClientManager = new ClientManager(2101, m_MountpointManager);
            m_CancellationToken = new CancellationTokenSource();
            m_WebGUI = new WebGUI(m_MountpointManager, m_CancellationToken);
        }
        public void Init()
        {
            _ = m_ClientManager.StartAsync();
            //var session = m_MountpointManager.GetMountpointSession("AGD_CORP");
            //session?.StreamRTCM();
            //session?.DecodeRTCM();
        }

        public async Task RunAsync()
        {
            Console.WriteLine("Caster running...");
            try
            {
                await Task.Delay(-1, m_CancellationToken.Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caster shutting down...");
            }
        }
        public async Task ShutdownAsync()
        {
            m_CancellationToken.Cancel();
            m_MountpointManager.Dispose();
            m_ClientManager.Dispose();
            await m_WebGUI.StopAsync();     
        }
        public void Run()
        {
            while (!m_CancellationToken.Token.IsCancellationRequested)
            {
                //var session = m_MountpointManager.GetMountpointSession("AGD_CORP");
                //session?.PrintMessages();
            }
        }
    }
}
