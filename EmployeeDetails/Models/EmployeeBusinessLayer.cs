using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            #region old1
            //List<Employee> employees = new List<Employee>();
            //Employee emp = new Employee();
            //emp.EmployeName = "Abhinanda";
            //emp.EmployeeID = 1018134;
            //emp.Gender = "Male";
            //emp.Salary = 34801;
            //employees.Add(emp);
            //emp = new Employee
            //{
            //    EmployeName = "Shubhamay",
            //    EmployeeID = 123455,
            //    Gender = "Male",
            //    Salary = 29000
            //};
            //employees.Add(emp);
            #endregion
            SalesEmp salesEmp = new SalesEmp();
            return salesEmp.Employees.ToList();
        }
    }
}