using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class EmployeeDepartment
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }

        public static List<EmployeeDepartment> GetallEmployeeDepartment()
        {
            List<EmployeeDepartment> employeesdepartment = new List<EmployeeDepartment>()
            {
              new EmployeeDepartment{EmployeeId = 1, EmployeeName ="mari",DepartmentId=1},
              new EmployeeDepartment{EmployeeId = 2, EmployeeName ="ravi",DepartmentId=2},
              new EmployeeDepartment{EmployeeId = 3, EmployeeName ="poorani",DepartmentId=1},
              new EmployeeDepartment{EmployeeId = 4, EmployeeName ="raju",DepartmentId=1},
              new EmployeeDepartment{EmployeeId = 5, EmployeeName ="divya",DepartmentId=2},
              new EmployeeDepartment{EmployeeId = 1, EmployeeName ="pooja",DepartmentId=1},
              new EmployeeDepartment{EmployeeId = 2, EmployeeName ="ravikumar",DepartmentId=1},
              new EmployeeDepartment{EmployeeId = 3, EmployeeName ="pooraniThai",DepartmentId=2},
              new EmployeeDepartment{EmployeeId = 4, EmployeeName ="raju bhai",DepartmentId=1},
              new EmployeeDepartment{EmployeeId = 5, EmployeeName ="for join"},
            };

            return employeesdepartment;
        }
    }
}
