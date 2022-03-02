using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Filters;
namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private List<Employee> _employee;

        public EmployeeController()
        {
            _employee = new List<Employee>
            {
                new Employee()
        { EmployeeId = 1,EmployeeName = "Jay",EmployeeDepartment="Clerk"},

            new Employee()
        { EmployeeId = 2,EmployeeName = "Jenny", EmployeeDepartment="Junior Manager"},

            new Employee()
        { EmployeeId = 3,EmployeeName = "Dhrutika",EmployeeDepartment="Senior Manager" },

            new Employee()
        { EmployeeId = 4,EmployeeName = "Sarfaraz",EmployeeDepartment="Purchase" },

            new Employee()
        { EmployeeId = 5,EmployeeName = "Ketan",EmployeeDepartment="Sales" },

            new Employee()
        { EmployeeId = 6,EmployeeName = "Bhavdip",EmployeeDepartment="Production" },

            new Employee()
        { EmployeeId = 7,EmployeeName = "Ruchi",EmployeeDepartment="Supply Chain Management" },

        };
}
        public IActionResult Index()
        {

            ViewBag.Name = "HCL";
            ViewData["Address"] = "Navsari";
            TempData["Name"] = "HCL";
            TempData.Keep();
            TempData["Address"] = "Navsari";
            TempData.Keep();

            return View(_employee);

        }
        [Filters.ActionResult]
        public IActionResult Info()
        {

         
            ViewData["Name"] = "Jenny patel";
            ViewBag.Info = TempData["Info"];
            TempData.Keep();
            return View();

        }
        [Filters.AsyncFilter]

        public IActionResult Message()
        {


            ViewData["Name"] = "ketan patel";
            ViewBag.Info = TempData["Info"];
          
            return View();

        }



        public IActionResult ViewById(int id)
        {
            ViewBag.Name = TempData ["Name"];
            ViewData["Address"] = TempData["Address"];
            var employee = _employee.FirstOrDefault(Option => Option.EmployeeId == id);
            return View(employee);
        }


    }
}
