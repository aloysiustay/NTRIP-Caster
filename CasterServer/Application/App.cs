using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasterServer.Mountpoint;

namespace CasterServer.Application
{
    public class App
    {
        public MountpointManager m_MountpointManager = new MountpointManager();

        public void Init()
        {
            var session = m_MountpointManager.GetMountpointSession("AGD_CORP");
            session?.DecodeRTCM();
        }

        public void Run()
        {
            while (true)
            {
                var session = m_MountpointManager.GetMountpointSession("AGD_CORP");
                session?.PrintMessages();
            }
        }

        public void Shutdown()
        {

        }
    }
}
