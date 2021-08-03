using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_03_08_21
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseMiddleware<TokenMiddleware>();



            app.UseErrorHandlingMiddleware()
               .UseToken("123456")
               .UseStaticFiles()
               .UseRoutingMiddleware();

            //   .Run(async context =>
            //{
            //    await context.Response.WriteAsync("Welcome to Shaki");
            //});

                            //app.MapWhen(context =>
                            //{
                            //    return context.Request.Query.ContainsKey("id") &&
                            //            context.Request.Query["id"] == "5";
                            //} , Index);

            
                    //app.Map("/home", home =>
                    //{
                    //    home.Map("/index", Index)
                    //        .Map("/about", About);
                 
                    //});

                    //app.Run(async context =>
                    //{
                    //    await context.Response.WriteAsync("Page Not found");
                    //});

            //app.Map("/index", Index)
            //   .Map("/about",About)
            //   .Run(async context => 
            //   {
            //       await context.Response.WriteAsync("Page Not found");
            //   });
        }
 

        private static void Index(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Index");
            });
        }

        private static void About(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("About");
            });
        }
    }
}
