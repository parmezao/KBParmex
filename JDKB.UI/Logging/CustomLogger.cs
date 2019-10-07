using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace JDKB.UI.Logging
{
    public class CustomLogger : ILogger
    {
        private readonly string loggerName;
        private readonly CustomLoggerProviderConfiguration loggerConfig;
        private readonly string _pathLogFile;

        public CustomLogger(string name, CustomLoggerProviderConfiguration config, string pathLogFile)
        {
            loggerName = name;
            loggerConfig = config;
            _pathLogFile = pathLogFile;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            string message = $"{logLevel.ToString()}: {eventId.Id} - {formatter(state, exception)}";

            WriteTextFile(message);
        }

        private void WriteTextFile(string message)
        {
            string path = _pathLogFile;

            if (string.IsNullOrEmpty(path))
                path = Path.GetTempPath();

            path = path.EndsWith(@"\") ? path : path + "\\";

            string filename = $"JDKB_{DateTime.Now.ToString("ddMMyyyy")}.log";

            string pathFileName = $@"{path}{filename}";

            if (!File.Exists(pathFileName))
            {
                File.Create(pathFileName).Dispose();
            };

            try
            {
                using (StreamWriter writer = new StreamWriter(pathFileName, true))
                {
                    writer.WriteLine(message);
                    writer.Close();
                }
            }
            catch (IOException)
            {
                // Erro ao tentar utilizar o arquivo e o mesmo está sendo usado por outro processo
            }
        }
    }
}
