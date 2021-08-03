using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_03_08_21
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RoutingMiddleware
    {
        private readonly RequestDelegate _next;

        public RoutingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            string path = httpContext.Request.Path.Value.ToLower();
            if (path == "/index")
            {
                await httpContext.Response.WriteAsync("Home Page");
            }
            else if (path == "/about")
            {
                await httpContext.Response.WriteAsync("About");
            }
            else
            {
                httpContext.Response.StatusCode = 404;
            }
            
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RoutingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRoutingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RoutingMiddleware>();
        }
    }
}
