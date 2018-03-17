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
            return View(employee);
        }

        // POST : Add Employee

        public ActionResult CreateEmployee()
        {
            return View("CreateEmployee");
        }

        public string SaveEmployee(Employee employee)
        {
            return employee.EmployeeName + " - " + employee.Salary;
        }
    }
}