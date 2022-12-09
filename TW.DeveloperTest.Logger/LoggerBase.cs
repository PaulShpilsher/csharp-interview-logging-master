using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Logger
{
    public abstract class LoggerBase : ILogger
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


        public abstract void Log(LogLevel logLevel, string message);
    }
}
