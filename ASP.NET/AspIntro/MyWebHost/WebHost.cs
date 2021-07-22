using AspIntro.MyWebHost;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AspIntro
{
    class WebHost
    {
        private int port;
        private HttpListener httpListener;
        private MiddlewareBuilder middlewareBuilder = new MiddlewareBuilder();
        private HttpHandle handle;

        public WebHost(int port)
        {
            this.port = port;
        }

        public void UseSturtup<T>() where T : IStartup
        {
            var startup = Activator.CreateInstance(typeof(T)) as IStartup;
            handle = startup.Configure(middlewareBuilder);
        }

        public void Run()
        {
            httpListener = new HttpListener();
            httpListener.Prefixes.Add($"http://localhost:{port}/");
            
            httpListener.Start();

            Console.WriteLine($"Server Started on port {port}");

            while (true)
            {
                var context = httpListener.GetContext();
                Task.Run(() =>
                {
                    HandleRequest(context);
                });
            }
        }

        public void HandleRequest(HttpListenerContext context)
        {
            handle(context);
        } 
    }
}
