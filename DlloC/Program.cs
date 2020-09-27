using DIIoC.Example1;
using System;
using Autofac;
using DIIoC.Example2;
using Autofac.Core;

namespace DIIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Facebook or Instagram? (0 or 1) ");
            var output = Console.ReadLine();
            var key = output == "0" ? "Facebook" : "Instagram";

            var builder = new ContainerBuilder();
            builder.RegisterType<InstagramPublisher>().As<IEventPublisher>().Keyed<IEventPublisher>("Instagram");
            builder.RegisterType<FacebookPublisher>().As<IEventPublisher>().Keyed<IEventPublisher>("Facebook");
            builder.RegisterType<FileLogger>().As<ILogger>();
            builder.RegisterType<EventCreator>().WithParameter(
                new ResolvedParameter(
                (pi, ctx) => pi.ParameterType == typeof(IEventPublisher),
                (pi, ctx) => ctx.ResolveKeyed<IEventPublisher>(key)));
            var container = builder.Build();

            var eventCreator = container.Resolve<EventCreator>();
            eventCreator.CreateEvent();

            /* Example2 */


            /* Example1 */
            //var c1 = new Client1(new Service1());
            //c1.ServeMethod();

            //var c2 = new Client2();
            //c2.Service = new Service1();
            //c2.ServeMethod();

            //var c3 = new Client3();
            //c3.ServeMethod(new Service2());
        }
    }
}
