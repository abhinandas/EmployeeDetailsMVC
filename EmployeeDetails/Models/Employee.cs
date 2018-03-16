using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public String EmployeName { get; set; }
        public String Gender { get; set; }
        public int Salary { get; set; }
        public string UserName { get; set; }
    }
}