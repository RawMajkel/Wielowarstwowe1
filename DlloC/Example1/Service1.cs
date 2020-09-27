using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example1
{
    class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Called from service 1");
        }
    }
}
