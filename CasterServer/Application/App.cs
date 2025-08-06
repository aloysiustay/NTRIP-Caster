using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasterServer.Mountpoint;
using CasterServer.GUI;
using CasterServer.Clock;

namespace CasterServer.Application
{
    public class App
    {
        public MountpointManager m_MountpointManager = new MountpointManager();
        public CancellationTokenSource m_CancellationToken = new CancellationTokenSource();
        public WebGUI? m_WebGUI;
        public void Init()
        {
            m_WebGUI = new WebGUI(m_MountpointManager, m_CancellationToken);
            var session = m_MountpointManager.GetMountpointSession("AGD_CORP");
            session?.StreamRTCM();
            session?.DecodeRTCM();
        }

        public void Run()
        {
            while (!m_CancellationToken.Token.IsCancellationRequested)
            {
                var session = m_MountpointManager.GetMountpointSession("AGD_CORP");
                //session?.PrintMessages();
            }
        }

        public async void Shutdown()
        {
            m_MountpointManager.Dispose();
            await m_WebGUI.StopAsync();
        }
    }
}
