using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;

namespace EmployeeManagement.Filters
{
    public class ActionResult : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
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
            Debug.WriteLine("********Result Executing*********************"); /*--3*/
        }



    }
}
