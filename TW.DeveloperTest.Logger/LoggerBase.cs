using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Logger
{
    public abstract class LoggerBase : ILogger, ILoggerWriter
    {
        public void Error(string message)
        {
            Log(LogLevel.Error, message);
        }

        public void Info(string message)
        {
            Log(LogLevel.Info, message);
        }

        public void Warning(string message)
        {
            Log(LogLevel.Warning, message);
        }


        public void Log(LogLevel logLevel, string message)
        {
            WriteLogEntry(new LogEntry
            {
                Level = logLevel,
                Timetamp = DateTime.Now,
                Message = message
            });

        }

        public abstract void WriteLogEntry(LogEntry logEntry);
    }
}
