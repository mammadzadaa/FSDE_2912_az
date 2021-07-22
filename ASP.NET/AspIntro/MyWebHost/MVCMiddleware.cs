using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace AspIntro.MyWebHost
{
    public class MVCMiddleware : IMiddleware
    {
        public HttpHandle Next { get; set; }

        public void Handle(HttpListenerContext context)
        {
            var parts = context.Request.RawUrl.Split('/', StringSplitOptions.RemoveEmptyEntries);
            var controllerName = parts[0] + "Controller";
            var methodName = parts[1];

            Assembly currentAssembly = Assembly.GetExecutingAssembly();          
            Type controllerType = currentAssembly.GetType("AspIntro.Controllers."+ controllerName);

            if (controllerType != null)
            {
                var controllerObj = Activator.CreateInstance(controllerType) as Controller;
                controllerObj.Context = context;
                var controllerMethod = controllerType.GetMethod(methodName);
                if (controllerMethod != null)
                {
                    controllerMethod.Invoke(controllerObj,null);                 
                }
                else
                {
                    Console.WriteLine("Page Not found!");
                }
            }
            else
            {
                Console.WriteLine("Page Not found!");
            }

            //Console.WriteLine($"Controller: {controllerName} and Method: {methodName}");

            Next?.Invoke(context);
        }
    }
}
