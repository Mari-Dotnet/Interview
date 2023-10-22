using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public static List<Department> getAlldepartments()
        {
            return new List<Department>()
            {
                new Department(){ Id = 1, Name = "HR"},
                new Department(){ Id = 2, Name = "IT"},
                new Department(){ Id = 3, Name = "PayRoll"},
            };
        }
    }
}
