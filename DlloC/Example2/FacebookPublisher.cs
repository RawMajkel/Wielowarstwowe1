using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example2
{
    class FacebookPublisher : IEventPublisher
    {
        public void Publish()
        {
            Console.WriteLine("Published on Facebook");
        }

        public void SendMessage()
        {
            Console.WriteLine("Message send by email");
        }
    }
}
