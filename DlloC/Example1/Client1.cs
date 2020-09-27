using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example1
{
    class Client1
    {
        private IService _service;

        public Client1(IService service)
        {
            _service = service;
        }

        public void ServeMethod()
        {
            _service.Serve();
        }
    }
}
