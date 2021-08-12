using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routing
{
    public class AdminRoute : IRouter
    {
        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            throw new NotImplementedException();
        }

        public async Task RouteAsync(RouteContext context)
        {
            string url = context.HttpContext.Request.Path.Value.TrimEnd('/');
            if (url.StartsWith("/Admin",StringComparison.OrdinalIgnoreCase))
            {
                context.Handler = async ctx =>
                {
                    ctx.Response.ContentType = "text/html;charset=utf-8";
                    var bytes = Encoding.UTF8.GetBytes("Hello Admin");
                    await ctx.Response.Body.WriteAsync(bytes, 0, bytes.Length);
                };
            }
            await Task.CompletedTask;
        }
    }
}
