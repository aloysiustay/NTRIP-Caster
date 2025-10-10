using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtcmSharp;

namespace ClientTest
{
    public class ClientApplication
    {
        public string gpgga = "$GPGGA,202530.00,5109.0262,N,11401.8407,W,5,40,0.5,1097.36,M,-17.00,M,18,TSTR*61\n";
        public RtcmStreamer m_Streamer;
        public CancellationTokenSource m_CancellationToken = new();
        public ClientApplication(string _mountpoint)
        {
            m_Streamer = new RtcmStreamer("192.168.171.254", 2101, _mountpoint);
        }



    }
}
