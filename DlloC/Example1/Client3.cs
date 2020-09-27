using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example1
{
    class Client3
    {
        public void ServeMethod(IService service)
        {
            service.Serve();
        }
    }
}
