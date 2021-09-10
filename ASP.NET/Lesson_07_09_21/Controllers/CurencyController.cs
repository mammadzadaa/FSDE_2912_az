using Lesson_07_09_21.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_07_09_21.Controllers
{
    public class MyAPIRequest
    {
        public string Curency { get; set; }
        public double Rate { get; set; }
    }

    [Route("[controller]")]
    [ApiController]
    public class CurencyController : ControllerBase
    {
        private readonly IExchangeService _exchangeService;
        public CurencyController(IExchangeService service)
        {
            _exchangeService = service;
        }
        [HttpGet]
        public double Get(string from, string to, double amount)
        {        
            try
            {
                return _exchangeService.Convert(from, to, amount);
            }
            catch (Exception)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status204NoContent;
                return 0;
            }
        }
        [HttpPost]
        public void Post(string curency, double rate)
        {
            if (curency?.Length < 5)
            {
                _exchangeService.AddRate(curency, rate);
            }
            else
            {
                HttpContext.Response.StatusCode = StatusCodes.Status204NoContent;
            }
        }
        //[HttpPost]
        //public void Post(MyAPIRequest request)
        //{
        //    if (request?.Curency.Length < 5)
        //    {
        //        _exchangeService.AddRate(request.Curency, request.Rate);
        //    }
        //    else
        //    {
        //        HttpContext.Response.StatusCode = StatusCodes.Status204NoContent;
        //    }
        //}
    }
}
