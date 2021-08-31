using Lesson_30_08_21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_30_08_21.Controllers
{
    public class Dimentions
    {        
        public int Heigth{ get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
    }
    [Controller]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Test()
        {
            return Ok("Halaldi Samur");

            //return Unauthorized();

            //return RedirectToRoute("default", new { controller = "Home", Action = "About" });

            //return Redirect("~/Home/About");
            
            //return new RedirectToActionResult("Index","Home",null);

            // return new JsonResult();

            //return new StatusCodeResult(400);

            //return new ObjectResult(new { Name = "Afti", Surname = "Mammadov", age = 25});

            //return new NoContentResult();

            //return new EmptyResult();

            //var res = new ContentResult();
            //res.Content = "Hello World";            
            //return res;
        }

        public string Volume(Dimentions dimentions)
        {
            
            return $"Width: {dimentions.Width}\nHeigth: {dimentions.Heigth}\nDepth: " +
                $"{dimentions.Depth}\nVolume: {dimentions.Depth * dimentions.Heigth * dimentions.Width}";
        }
        
        [HttpPost]
        public string Area(int width, int heigth)
        {
            return $"Wdth: {Request.Form.FirstOrDefault(p => p.Key == "width").Value} and Heigth: {heigth} \nArea: {width * heigth}";
        }

        public string Sum(int[] nums)
        {
            return $"Sum: {nums.Sum()}";
        }

        //public string Sum(int a = 5, int b = 3)
        //{
        //    return $"{a} + {b} = {a + b}";
        //}
        [NonAction]
        public string Hello()
        {
            return "Hello from Shaki!";
        }
        [HttpGet]
        public IActionResult Index()
        {            
            return View();
        }
        [ActionName("Afti"),HttpPost]
        public IActionResult Privacy()
        {
            return View("~/Views/Home/Privacy.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
