using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
    [Table("TblEmployees")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public String EmployeeName { get; set; }
        public String Gender { get; set; }
        public int Salary { get; set; }
    }
}