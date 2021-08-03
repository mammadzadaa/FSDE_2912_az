using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspWebApp.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            ControllerContext.HttpContext.Response.ContentType = "text/html";
            var body = "<h1> Index Page</h1>";
            var bytes = Encoding.UTF8.GetBytes(body);
            ControllerContext.HttpContext.Response.Body.WriteAsync(bytes, 0, bytes.Length);
     
        }
    }
}
