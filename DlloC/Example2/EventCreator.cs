using System;
using System.Collections.Generic;
using System.Text;

namespace DIIoC.Example2
{
    class EventCreator
    {
        private IEventPublisher _eventPublisher;
        private ILogger _logger;

        public EventCreator(IEventPublisher eventPublisher, ILogger logger)
        {
            _eventPublisher = eventPublisher;
            _logger = logger;
        }

        public void CreateEvent()
        {
            //saving to db
            //...
            _eventPublisher.Publish();
            //logging
            _logger.Log($"Event published at: {DateTime.Now}");
        }
    }
}
