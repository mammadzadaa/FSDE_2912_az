using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AspIntro.MyWebHost
{
    abstract class Controller
    {
        public HttpListenerContext Context { get; set; }

        public JsonResult Json(object obj)
        {
            var jsonResult = new JsonResult(obj);
            jsonResult.ExecuteResult(Context);
            return jsonResult;
        }

        public ViewResult View()
        {
            var viewResult = new ViewResult();
            viewResult.ExecuteResult(Context);
            return viewResult;
        }
    }
}
