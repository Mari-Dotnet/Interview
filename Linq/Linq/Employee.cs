using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public int salary { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetallEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
              new Employee{EmployeeId = 1, EmployeeName ="mari",Gender ="Male",salary=10000,Department="IT"},
              new Employee{EmployeeId = 2, EmployeeName ="ravi",Gender ="Male",salary=9000,Department="HR"},
              new Employee{EmployeeId = 3, EmployeeName ="poorani",Gender ="FeMale",salary=8500,Department="IT"},
              new Employee{EmployeeId = 4, EmployeeName ="raju",Gender ="Male",salary=7000,Department="HR"},
              new Employee{EmployeeId = 5, EmployeeName ="divya",Gender ="FeMale",salary=9500,Department="IT"},
              new Employee{EmployeeId = 1, EmployeeName ="pooja",Gender ="FeMale",salary=10000,Department="IT"},
              new Employee{EmployeeId = 2, EmployeeName ="ravikumar",Gender ="Male",salary=9000,Department="HR"},
              new Employee{EmployeeId = 3, EmployeeName ="pooraniThai",Gender ="FeMale",salary=8500,Department="IT"},
              new Employee{EmployeeId = 4, EmployeeName ="raju bhai",Gender ="Male",salary=7000,Department="HR"},
              new Employee{EmployeeId = 5, EmployeeName ="divya prakash",Gender ="FeMale",salary=9500,Department="IT"},
            };

            return employees;
        }
    }
}
