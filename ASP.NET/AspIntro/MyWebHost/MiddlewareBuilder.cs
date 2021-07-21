using AspIntro.MyWebHost;
using System;
using System.Collections.Generic;

namespace AspIntro
{
    public class MiddlewareBuilder
    {
        private Stack<Type> middlewares = new Stack<Type>();
        public void Use<T>() where T : IMiddleware
        {
            middlewares.Push(typeof(T));
        }

        public HttpHandle Build()
        {
            HttpHandle handle = c => c.Response.Close();

            while (middlewares.Count > 0)
            {
                var current = Activator.CreateInstance(middlewares.Pop()) as IMiddleware;
                current.Next = handle;
                handle = current.Handle;
            }
            return handle;            
        }
    }
}