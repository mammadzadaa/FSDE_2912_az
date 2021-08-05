using Lesson_05_08_21.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_05_08_21.MIddlewares
{
    public class MessageMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IMessageSender _messageSender;

        public MessageMiddleware(RequestDelegate next, IMessageSender messageSender)
        {
            _next = next;
            _messageSender = messageSender;
        }

        public async Task InvokeAsync(HttpContext context/*, IMessageSender messageSender*/)
        {
            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync(_messageSender.Send());
            //context.RequestServices.GetService<TimeService>().GetTime();

        }
    }

    public static class MessageExtention
    {
        public static IApplicationBuilder UseMyMessage(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MessageMiddleware>();
        }
    }
}
