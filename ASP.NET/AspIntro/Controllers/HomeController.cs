using AspIntro.MyWebHost;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspIntro.Controllers
{
    class HomeController : Controller
    {
        public void Index()
        {
            var str = "Index page";
            var bytes = Encoding.UTF8.GetBytes(str);
            Context.Response.OutputStream.Write(bytes,0,bytes.Length);

        }
        //public string Contacts()
        //{
        //    return "Contacts page";
        //}

        //public string About()
        //{
        //    return "About page";
        //}
    }
}
