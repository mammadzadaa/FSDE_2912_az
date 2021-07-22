using AspIntro.MyWebHost;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspIntro
{
    class Startup : IStartup
    {
        public HttpHandle Configure(MiddlewareBuilder builder)
        {
            builder.Use<LoggerMiddleware>();
            builder.Use<StaticFilesMiddleware>();
            builder.Use<MVCMiddleware>();

            return builder.Build();
        }
    }
}
