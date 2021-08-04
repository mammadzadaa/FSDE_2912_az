using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_04_08_21
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

            //app.UseStatusCodePages();
            //app.UseStatusCodePages("text/html","<h1>Basha Dushmeyenler uchun! Status code {0}</h1>");
            app.UseStatusCodePagesWithReExecute("/error","?code={0}");
            app.UseStatusCodePagesWithRedirects("/error?code={0}");

            app.Map("/error", ap => ap.Run(async c => 
            {
                await c.Response.WriteAsync($"Err: {c.Request.Query["code"]}");
            }));

            app.Map("/hello", ap => ap.Run(async c => await c.Response.WriteAsync("Welcome")));


            //env.EnvironmentName = "Production";
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/error");
            //}

            //app.Map("/error", ap => ap.Run(async c => await c.Response.WriteAsync("DevideByZeroException occured")));

            //app.Run(async context =>
            //{
            //    int x = 8;
            //    int y = 0;
            //    await context.Response.WriteAsync($"x / y = {x / y}");
            //});

            //app.UseFileServer(enableDirectoryBrowsing: true);
            //app.UseFileServer(new FileServerOptions()
            //{
            //    EnableDirectoryBrowsing = true,
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Home")),
            //    RequestPath = new PathString("/pages"),
            //    EnableDefaultFiles = false                
            //}) ;


            //app.UseDirectoryBrowser(new DirectoryBrowserOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),@"wwwroot\Home")),
            //    RequestPath = new PathString("/pages")       

            //}); 

            //DefaultFilesOptions options = new DefaultFilesOptions();
            //options.DefaultFileNames.Clear();
            //options.DefaultFileNames.Add("wandam.html");
            //options.DefaultFileNames.Add("afti.html");
            //app.UseDefaultFiles(options);

            app.UseStaticFiles();
        }
    }
}
