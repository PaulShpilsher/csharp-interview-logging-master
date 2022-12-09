using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Logger
{
    public class ConsoleLogger : LoggerBase
    {
        public override void WriteLogEntry(LogEntry logEntry)
        {
            Console.WriteLine($"{logEntry.Timestamp} | {LogLevelToString(logEntry.Level)} || {logEntry.Message}");
        }

        private static string LogLevelToString(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Error: return "ERROR";
                case LogLevel.Warning: return "WARNING";
                case LogLevel.Info: return "INFO";
                default: return "UNKNOWN";
            }
        }
    }
}
