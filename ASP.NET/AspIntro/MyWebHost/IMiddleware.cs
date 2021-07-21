using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AspIntro.MyWebHost
{
   public delegate void HttpHandle(HttpListenerContext context);

    public interface IMiddleware
    {
        public HttpHandle Next { get; set; }

        public void Handle(HttpListenerContext context)
        {
            context.Response.Close();
        }
    }
}
