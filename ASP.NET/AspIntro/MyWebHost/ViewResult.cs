using System;
using System.IO;
using System.Net;

namespace AspIntro.MyWebHost
{
    public class ViewResult : IActionResult
    {
        public void ExecuteResult(HttpListenerContext context)  
        {
            var parts = context.Request.RawUrl.Split('/', StringSplitOptions.RemoveEmptyEntries);
            var controllerName = parts[0];
            var methodName = parts[1];
            var path = Directory.GetCurrentDirectory() + "/View/" + controllerName + "/" + methodName + ".html";
            var bytes = File.ReadAllBytes(path);
            context.Response.ContentType = "text/html";
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        }
    }
}