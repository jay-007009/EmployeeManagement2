using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;

namespace EmployeeManagement.Filters
{
    [AttributeUsage(
        AttributeTargets.Method,
        AllowMultiple =true)]
    public class ActionResult : ActionFilterAttribute /*Attribute, IAsyncActionFilter*/
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            (filterContext.Result as ViewResult).ViewData["Name"] = "jay patel";
            base.OnActionExecuted(filterContext);

            Debug.WriteLine("***********Action Executed**************");  /* --2*/

        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("**********Action Executing**************"); /*--1*/
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("****************Result Executed****************"); /*--4*/
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            (filterContext.Result as ViewResult).ViewData["Name"] = "kumar patel";
            base.OnResultExecuting(filterContext);

            Debug.WriteLine("********Result Executing*********************"); /*--3*/
        }
        //public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        //{
        //    await.next();
        //}
    }
}
