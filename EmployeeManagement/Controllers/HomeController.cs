using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
      
        public IActionResult Index()
        {
            TempData["Name"] = "Jay Patel ";
            TempData["Contact"] = 2555666;
            TempData.Keep();
            return View();
        }

        public IActionResult EmployeeName()
        {
            ViewBag.Name = TempData["Name"];
            TempData.Keep();
            return View();
        }



        public IActionResult Result()
        {
            ViewData["Name"] = TempData["Name"];
            string str = TempData.Peek("Contact").ToString();
            TempData["Contact"] = str;
            return View();
        }

        public IActionResult Privacy ()
        {
           
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
