using Lesson_05_08_21.MIddlewares;
using Lesson_05_08_21.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_08_21
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //private IServiceCollection _services;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<EmailMessageSender>();
            services.AddTransient<IMessageSender>(provider =>
            {
                if (DateTime.Now.Hour >= 12) return provider.GetService<EmailMessageSender>();
                return new SmsMessageSender();
            });

            services.AddSingleton<ICounter, RandomCounter>();
            services.AddSingleton<CounterService>();

            //services.AddScoped<ICounter, RandomCounter>();
            //services.AddScoped<CounterService>();

            //services.AddTransient<ICounter, RandomCounter>();
            //services.AddTransient<CounterService>();

            //_services = services;
            //services.AddTransient<IMessageSender, EmailMessageSender>();
            //services.AddTransient<TimeService>();
            //services.AddTimeService();

            //services.AddTransient();
            //services.AddScoped();
            //services.AddSingleton();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env/*,TimeService timeService*/)
        {
            app.UseMiddleware<CounterMiddleware>();
           // app.UseMyMessage();
           //app.Run(async context =>
           //{
           //    //app.ApplicationServices.GetService<TimeService>().GetTime();
           //    //context.RequestServices.GetService<TimeService>().GetTime();
           //    await context.Response.WriteAsync($"Time is {timeService?.GetTime()}");
           //});

            //app.Run(async context => 
            //{
            //    await context.Response.WriteAsync(messageSender.Send());
            //});
            //app.Run(async context =>
            //{
            //    var sb = new StringBuilder();
            //    sb.Append("<h1>All services</h1></br>");
            //    sb.Append("<table>");
            //    sb.Append("<tr><th>Type</th><th>Lifetime</th><th>Realization</th></tr>");
            //    foreach (var svc in _services)
            //    {
            //        sb.Append("<tr>");
            //        sb.Append($"<td>{svc.ServiceType.FullName}</td>");
            //        sb.Append($"<td>{svc.Lifetime}</td>");
            //        sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
            //        sb.Append("</tr>");
            //    }
            //    sb.Append("</table>");
            //    context.Response.ContentType = "text/html;charset=utf-8";
            //    await context.Response.WriteAsync(sb.ToString());
            //});
        }
    }
}
