using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AspIntro.MyWebHost
{
    abstract class Controller
    {
        public HttpListenerContext Context { get; set; }
    }
}
