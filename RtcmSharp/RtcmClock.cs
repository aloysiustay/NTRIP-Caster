using System.Diagnostics;
using GuerrillaNtp;

namespace CasterServer.Clock
{
    public class RtcmClock
    {
        private static DateTimeOffset m_UtcTime;
        private static Stopwatch m_Stopwatch = Stopwatch.StartNew();
        private static readonly object m_Lock = new();
        private static readonly TimeSpan m_ResyncInterval = TimeSpan.FromMinutes(10);
        private static CancellationTokenSource? m_CancellationTokenSource = null;

        static RtcmClock()
        {
            Sync();
            StartAutoResync();
        }
        public static bool Sync()
        {
            try
            {
                NtpClient client = NtpClient.Default;
                NtpClock clock = client.Query();

                lock (m_Lock)
                {
                    m_UtcTime = clock.UtcNow;
                    m_Stopwatch.Restart();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"NTP Sync failed: {ex.Message}");
                return false;
            }
        }

        public static DateTimeOffset GetUtcTime()
        {
            lock (m_Lock)
            {
                return m_UtcTime + m_Stopwatch.Elapsed;
            }
        }

        public static DateTimeOffset GetLocalTime()
        {
            return GetUtcTime().ToLocalTime();
        }

        private static void StartAutoResync()
        {
            m_CancellationTokenSource = new CancellationTokenSource();
            var token = m_CancellationTokenSource.Token;

            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    await Task.Delay(m_ResyncInterval, token);

                    if (!token.IsCancellationRequested)
                    {
                        Sync();
                    }
                }
            }, token);
        }

        public static void StopAutoResync()
        {
            m_CancellationTokenSource?.Cancel();
        }
    }
}
