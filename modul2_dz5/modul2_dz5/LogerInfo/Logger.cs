namespace Modul2_dz5.LogerInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Modul2_dz5.Enum;

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

        public string Logs => this.logs.ToString();

        public void LogEventInfo(string message)
        {
            this.LogEvent(LogType.Info, message);
        }

        public void LogEventWarning(string message)
        {
            this.LogEvent(LogType.Warning, message);
        }

        public void LogEventError(string message)
        {
            this.LogEvent(LogType.Error, message);
        }

        public void LogEvent(LogType logType, string message)
        {
            var logMessage = $"{DateTime.UtcNow}: {logType}: {message}";

            Console.WriteLine(logMessage);
            this._logs.AppendLine(logMessage);
        }
    }
}
