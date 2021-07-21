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

        public WebHost(int port)
        {
            this.port = port;
        }

        public void Run()
        {
            httpListener = new HttpListener();
            httpListener.Prefixes.Add($"http://localhost:{port}/");
            httpListener.Prefixes.Add($"http://10.1.10.4:{port}/");
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
            StaticFilesMiddleware staticFilesMiddleware = new StaticFilesMiddleware();
            LoggerMiddleware loggerMiddleware = new LoggerMiddleware();

            loggerMiddleware.Next = staticFilesMiddleware.Handle;
            staticFilesMiddleware.Next = c => c.Response.Close();
            loggerMiddleware.Handle(context);
        } 
    }
}
