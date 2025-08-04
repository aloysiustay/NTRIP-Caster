using System.Diagnostics;
using GuerrillaNtp;

namespace CasterServer.Clock
{
    public class Clock
    {
        private DateTimeOffset m_UtcTime { get; set; }
        private Stopwatch m_Stopwatch { get; set; }
        public Clock() 
        {
            m_Stopwatch = Stopwatch.StartNew();
            sync();
        }
        public bool sync()
        {
            try
            {
                NtpClient client = NtpClient.Default;
                NtpClock clock = client.Query();
                m_UtcTime = clock.UtcNow;
                m_Stopwatch.Restart();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"NTP Sync failed: {ex.Message}");
                return false;
            }
        }

        public DateTimeOffset GetUtcTime()
        {
            return m_UtcTime + m_Stopwatch.Elapsed;
        }

        public DateTimeOffset GetLocalTime()
        {
            return (m_UtcTime + m_Stopwatch.Elapsed).ToLocalTime();
        }
    }
}
