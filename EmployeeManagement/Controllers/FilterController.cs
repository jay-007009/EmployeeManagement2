using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Filters;
namespace EmployeeManagement.Controllers
{
    public class FilterController : Controller
    {
       
        [Filters.ActionResult]
        public IActionResult Index()
        {
            ViewBag.Message = "Action Filter";
            return View();
        }
        
       



    }
}
