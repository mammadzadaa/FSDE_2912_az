using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AspIntro.MyWebHost
{
    class JsonResult : IActionResult
    {
        private object recievedObject;
        public JsonResult(object obj)
        {
            recievedObject = obj;
        }
        public void ExecuteResult(HttpListenerContext context)
        {
            var serializedObject = JsonConvert.SerializeObject(recievedObject);
            var bytes = Encoding.UTF8.GetBytes(serializedObject);
            context.Response.ContentType = "application/json";
            context.Response.OutputStream.Write(bytes,0,bytes.Length);
        }
    }
}
