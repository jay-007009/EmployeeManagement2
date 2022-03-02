using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EmployeeManagement.Filters
{
    public class AsyncFilter : Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute, IAsyncActionFilter
    {
        public override void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Async Action Executing");
        }
        public override async Task OnActionExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context, ActionExecutionDelegate next)
        {
            this.OnActionExecuting(context);
            var resultContext = await next();
            this.OnActionExecuted(resultContext);
        }

        public override void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context)
        {
            Debug.WriteLine("Async Action Executed");
        }



        public override void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext filterContext)
        {
            Debug.WriteLine("Result Action Executing");
        }
        public override async Task OnResultExecutionAsync(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context, ResultExecutionDelegate next)
        {
            this.OnResultExecuting(context);
            var resultContext = await next();
            this.OnResultExecuted(resultContext);
        }

        public override void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context)
        {
            Debug.WriteLine("Result Action Executed");
        }




    }
}
