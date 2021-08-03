using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AspIntro.MyWebHost
{
    interface IActionResult
    {
        public void ExecuteResult(HttpListenerContext context);
    }
}
