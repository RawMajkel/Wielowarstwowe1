using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example2
{
    interface ILogger
    {
        void Log(string message);
        void ClearLog();
    }
}
