using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDetails.Models;
using EmployeeDetails.ViewModel;

namespace EmployeeDetails.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeBusinessLayer empbl = new EmployeeBusinessLayer();

        public ActionResult GetEmployee()
        {
            EmployeeViewModel employee = new EmployeeViewModel();
            List<Employee> lst = new List<Employee>();
            lst = empbl.GetEmployees();
            employee.Employees = lst;
            employee.UserName = "Abhi";
            return View(employee);
        }
    }
}