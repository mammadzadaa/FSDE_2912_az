using AspIntro.MyWebHost;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspIntro.Controllers
{
    class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var str = "Index page";
            //var bytes = Encoding.UTF8.GetBytes(str);
            //Context.Response.OutputStream.Write(bytes,0,bytes.Length);

            return Json(new { name = "Afti", surname = "Mammadov" });

        }
        public IActionResult Contacts()
        {
            return View();
        }

        //public string About()
        //{
        //    return "About page";
        //}
    }
}
