using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;

namespace JDKB.UI.Logging
{
    public class CustomLoggerProvider : ILoggerProvider
    {
        private readonly CustomLoggerProviderConfiguration loggerConfig;
        private readonly string _pathLogFile;
        private ConcurrentDictionary<string, CustomLogger> loggers = new ConcurrentDictionary<string, CustomLogger>();

        public CustomLoggerProvider(CustomLoggerProviderConfiguration config, string pathLogFile)
        {
            loggerConfig = config;
            _pathLogFile = pathLogFile;
        }

        public ILogger CreateLogger(string category)
        {
            return loggers.GetOrAdd(category, name => new CustomLogger(name, loggerConfig, _pathLogFile));
        }

        public void Dispose()
        {
        }
    }
}
