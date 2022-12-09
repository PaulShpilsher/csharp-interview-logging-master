using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Logger
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message);

        void Error(string message);
        void Warning(string message);
        void Info(string message);

    }
}
