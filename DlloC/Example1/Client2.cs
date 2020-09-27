using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example1
{
    class Client2
    {
        private IService _service;

        public IService Service
        {
            set
            {
                _service = value;
            }
        }

        public void ServeMethod()
        {
            _service.Serve();
        }
    }
}
