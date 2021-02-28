using System;
using System.Collections.Generic;
using System.Text;
using modul2_dz5.Enum;

namespace modul2_dz5.LogerInfo
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly StringBuilder _logs = new StringBuilder();

        static Logger()
        {
        }
        private Logger()
        {
        }

        public static Logger Instance => _instance;
        public string Logs => _logs.ToString();
        public void LogEventInfo(string message)
        {
            LogEvent(LogType.Info, message);
        }
        public void LogEventWarning(string message)
        {
            LogEvent(LogType.Warning, message);
        }
        public void LogEventError(string message)
        {
            LogEvent(LogType.Error, message);
        }
        public void LogEvent(LogType logType, string message)
        {
            var logMessage = $"{DateTime.UtcNow}: {logType}: {message}";

            Console.WriteLine(logMessage);
            _logs.AppendLine(logMessage);
        }
    }
}
