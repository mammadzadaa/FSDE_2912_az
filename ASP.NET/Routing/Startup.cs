using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Routing
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        private async Task Handle(HttpContext context)
        {
            var routeValues = context.GetRouteData().Values;

            await context.Response.WriteAsync($"{routeValues["controller"].ToString()}\n{routeValues["action"]}\n{routeValues["catchall"]}");
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var routeBuilder = new RouteBuilder(app);

            routeBuilder.Routes.Add(new AdminRoute());

            
            routeBuilder.MapRoute("{controller}/{action}",
                async context =>
                {
                    await context.Response.WriteAsync("Hello User");
                });

            app.UseRouter(routeBuilder.Build());

            
            //var myRouteHandler = new RouteHandler(Handle);
            // var myRouteHandler = new RouteHandler(async context => { await context.Response.WriteAsync("Hello World"); });
            
            //var routeBuilder = new RouteBuilder(app, myRouteHandler);
            //routeBuilder.MapRoute("{x}/{y}", 
            //    async context =>
            //    {
            //        await context.Response.WriteAsync("Hey There");
            //    });

            //routeBuilder.MapRoute("default","{controller:length(5)}/{action}/{id:int?}/{*catchall}");
            
            //routeBuilder.MapRoute("default", "{controller}/{action}/{id?}",
            //   new { controller = "home", action = "index" }
            //   , new { controller = new RegexRouteConstraint("^[A-G].*"),
            //       id = new CompositeRouteConstraint(new IRouteConstraint[]
            //       {
            //           new IntRouteConstraint(),
            //           new RangeRouteConstraint(0,255)
            //       }),
            //       httpMethod = new HttpMethodRouteConstraint("GET")});
            //DecimalRouteConstraint
            //DateTimeRouteConstraint
            /*BoolRouteConstraint*/
            /*AlphaRouteConstraint*/

            //routeBuilder.MapRoute("default","{controller}/{action}/{id?}",
            //    new { controller = "home", action = "index" }
            //    ,new {controller = "^[a-g].*", id = @"\d{2,5}"});

            //routeBuilder.MapRoute("default", "{controller}-{action}/{*catchall}");
            //routeBuilder.MapRoute("default","Az{controller=Home}/{action=Index}-en/{id?}/{*catchall}");
            //routeBuilder.MapRoute("default","{controller}/{action}/{id?}/{*catchall}");
            //routeBuilder.MapRoute("default","{controller}/{action}/{id?}", new {controller = "home", action = "index"});
            //routeBuilder.MapRoute("default","api/{controller}/{action}/{id?}");
            //app.UseRouter(routeBuilder.Build());
            
            app.Run(async context => { await context.Response.WriteAsync("No such route"); });
                    //    if (env.IsDevelopment())
                    //    {
                    //        app.UseDeveloperExceptionPage();
                    //    }

                    //    app.UseRouting();

                    //    app.Use(async (context, next) =>
                    //    {
                    //        var endpoint = context.GetEndpoint();
                    //        if (endpoint != null)
                    //        {
                    //            var routePattern = (endpoint as RouteEndpoint)?.RoutePattern?.RawText;

                    //            Debug.WriteLine($"Endpoint Name: {endpoint.DisplayName}");
                    //            Debug.WriteLine($"Endpoint Pattern: {routePattern}");

                    //            await next();
                    //        }
                    //        else
                    //        {
                    //            Debug.WriteLine("Endpoint is null");
                    //            await context.Response.WriteAsync("Endpoint is not defined!");
                    //        }
                    //    });

                    //    app.UseEndpoints(endpoints =>
                    //    {
                    //        endpoints.MapGet("/index", async context =>
                    //        {
                    //            await context.Response.WriteAsync($"{context.Request.Path.Value}");
                    //        });
                    //        endpoints.MapGet("/", async context =>
                    //        {
                    //            await context.Response.WriteAsync("Hello world");
                    //        });
                    //    });
        }
    }
}
