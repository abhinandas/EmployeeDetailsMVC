using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
    public class SalesEmp : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}