using System;
using System.Collections.Generic;
using System.Text;

namespace Emie
{
    internal enum LoggingType
    {
        INFO, WARN, ERROR, DEBUG
    }

    internal interface ILogger
    {
        void info(string message, params string[] args);
        void warn(string message, params string[] args);
        void error(string message, params string[] args);
    }
}
