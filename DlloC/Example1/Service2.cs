using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example1
{
    class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Called from service 2");
        }
    }
}
