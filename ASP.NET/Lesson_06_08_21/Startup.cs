using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_06_08_21
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("person.json");
            //var builder = new ConfigurationBuilder().AddJsonFile("settings.json")
            //                                        .AddConfiguration(configuration);
            AppConfiguration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IConfiguration>(provider => AppConfiguration);
        }

        public IConfiguration AppConfiguration { get; set; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var tom = new Person();
            AppConfiguration.Bind(tom);

            app.Run(async context =>
            {
                await context.Response.WriteAsync($"<h1>Name: {tom.Name}</h1><p>Age: {tom.Age}</p>");
            });

            //app.UseMiddleware<ConfigurationMiddleware>();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync(AppConfiguration["name"]);
            //    });
            //});
        }
    }
}
