using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace lesson_09_08_21
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = "Afti";
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
               
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();
            app.Use(async (context, next) =>
            {
                Person p = new Person();
                context.Session.SetString("person", JsonSerializer.Serialize<Person>(p));
                context.Session.SetString("mysessionkey", "my session value");
                
                if (context.Request.Cookies.ContainsKey("myKey"))
                {
                    context.Response.Cookies.Delete("myKey");
                }
                else
                {
                    context.Response.Cookies.Append("myKey","MyData");
                }

            context.Items.Add("token", "123456");
            await next.Invoke();
            await context.Response.WriteAsync($"{context.Items["token"]}");
            });

            app.Run(async context =>
            {
                context.Items["token"] = "qwerty";
            });
        }
    }
}
