using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_03_08_21
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string pattern;

        public TokenMiddleware(RequestDelegate next, string pattern)
        {
            _next = next;
            this.pattern = pattern;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];
            if (token != pattern)
            {
                context.Response.StatusCode = 403;
                //await context.Response.WriteAsync("Token is Invalid");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }

    public static class TokenExtention
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern)
        {
            return builder.UseMiddleware<TokenMiddleware>(pattern);
        }
    }

}
