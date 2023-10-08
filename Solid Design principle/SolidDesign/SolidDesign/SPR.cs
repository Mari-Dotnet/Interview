using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    //single responsblity principle
    //class should have only one responseblity
    //should have onlt one reason to change

    //Micro service archietur also working same principle

    #region SPA implemented
    //one more example
    //add inovice and delete invoice one class
    //email send, error logging in other class
    public class SPR
    {
        public int calculatedsalary()
        {
            return 0;
        }
        public string report()
        {
            return string.Empty;
        }
    }


    public class employeerepository
    {
        public void save()
        {
            //save employee to database
        }
    }
    #endregion

    #region before SPA implemente
    public class Employee
    {
        //own responseblity
        public int calculatesalary()
        {
            return 0;
        }
        //own responseblity
        public string  getreport()
        {
            return "";
        }

        //extra responblity
        public void save()
        {
            //save the data to database
        }
    }

    #endregion
}
