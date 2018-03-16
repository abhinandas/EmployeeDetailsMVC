using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDetails.Models;

namespace EmployeeDetails.ViewModel
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public string UserName { get; set; }
    }
}