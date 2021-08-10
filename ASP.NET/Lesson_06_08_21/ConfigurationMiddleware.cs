using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_06_08_21
{
    public class ConfigurationMiddleware
    {
        private readonly RequestDelegate _next;
        public IConfiguration AppConfiguration { get; set; }

        public ConfigurationMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            AppConfiguration = config;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            IConfigurationSection confSection = AppConfiguration.GetSection("ConnectionString");
            //await context.Response.WriteAsync($"{AppConfiguration["ConnectionString:DefaultConnection"]}");
            
            //await context.Response.WriteAsync($"{confSection.GetSection("DefaultConnection").Value}");
            
            //await context.Response.WriteAsync($"name: {AppConfiguration["name"]} age: {AppConfiguration["age"]}");
        }

    }
}
