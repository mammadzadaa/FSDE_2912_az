using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_09_09_21.Filters
{
    public class SimpleFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            context.HttpContext.Response.Cookies.Append("LastVisited", DateTime.Now.ToString("dd/MM/yyyy hh-mm-ss"));
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (false)
            {
                context.Result = new ContentResult { Content = "Not auth" };
            }
        }
    }
}
