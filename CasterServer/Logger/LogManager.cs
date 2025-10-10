using Microsoft.Extensions.Logging;

namespace CasterServer.Logger
{
    public class LogManager
    {
        public readonly ILoggerFactory m_LogFactory;

        public LogManager()
        {
            m_LogFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.AddDebug();
                builder.SetMinimumLevel(LogLevel.Information);
            });
        }
    }
}
