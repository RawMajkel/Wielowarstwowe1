using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example2
{
    interface IEventPublisher
    {
        void Publish();
        void SendMessage();
    }
}
