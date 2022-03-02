using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
       
        public int EmployeeId { get; set; }
        //[Required(ErrorMessage ="Name is required")]
        public string EmployeeName { get; set; }

       public string EmployeeDepartment { get; set; }

       

    }
}
