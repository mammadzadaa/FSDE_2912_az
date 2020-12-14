using SimpleInjector;
using System;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Container services = new Container();
            services.Register<ILogger,Logger>();
            services.Register<IApiService, ApiService>();
            services.Register<IStorage, Storage>();
            services.Register<Mediator>();
            services.Verify();

            Mediator mediator = services.GetInstance<Mediator>();

            Console.WriteLine("Hello World!");
        }
    }
}
