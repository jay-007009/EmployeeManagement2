using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
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
        { EmployeeId = 2,EmployeeName = "Jenny"},

            new Employee()
        { EmployeeId = 3,EmployeeName = "Dhrutika" },

            new Employee()
        { EmployeeId = 4,EmployeeName = "Sarfaraz" },

            new Employee()
        { EmployeeId = 5,EmployeeName = "Ketan" },

            new Employee()
        { EmployeeId = 6,EmployeeName = "Bhavdip" },

            new Employee()
        { EmployeeId = 7,EmployeeName = "Ruchi" },

        };
}
        public IActionResult Index()
        {
            ViewBag.Name = "1Rivet";
            ViewData["Address"] = "Navsari";
            return View(_employee);
        }

       
    }
}
