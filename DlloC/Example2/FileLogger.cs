using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example2
{
    class FileLogger : ILogger
    {
        public void ClearLog()
        {
            Console.WriteLine("Cleared");
        }

        public void Log(string message)
        {
            Console.WriteLine("Saved file");
        }
    }
}
