using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Logger
{
    public class LogEntry
    {
        public LogLevel Level { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
    }
}
