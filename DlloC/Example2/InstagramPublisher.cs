using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example2
{
    class InstagramPublisher : IEventPublisher
    {
        public void Publish()
        {
            Console.WriteLine("Published on Instagram");
        }

        public void SendMessage()
        {
            Console.WriteLine("Message send on chat");
        }
    }
}
