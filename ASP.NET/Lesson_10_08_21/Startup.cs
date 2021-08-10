using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_10_08_21
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, /*ILogger<Startup> logger,*/ IWebHostEnvironment env)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                //builder.AddDebug().SetMinimumLevel(LogLevel.Warning);
           
            });
            loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(),"log.txt"));
            ILogger logger = loggerFactory.CreateLogger("FileLogger");

           

            app.Run(async context =>
            {

                logger.LogInformation("Processing request {0}", context.Request.Path);
                logger.Log(LogLevel.Critical, "{0} {1}", "Your age is", 15);
                
                await context.Response.WriteAsync("Hello World");
            });
        }
    }
}
