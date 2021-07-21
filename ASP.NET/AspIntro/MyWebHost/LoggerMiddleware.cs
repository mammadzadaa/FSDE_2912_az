using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AspIntro.MyWebHost
{
    class LoggerMiddleware : IMiddleware
    {
        public HttpHandle Next { get; set; }

        public void Handle(HttpListenerContext context)
        {
            Console.WriteLine($"{context.Request.HttpMethod} {context.Request.RawUrl} {context.Request.RemoteEndPoint}");
            Next?.Invoke(context);
        }
    }
}
