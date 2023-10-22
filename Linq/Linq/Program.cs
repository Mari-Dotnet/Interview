using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Quantifier always retun the true/ false value
            //all any contains
            var anyemployee = Employee.GetallEmployees().Any();
            int[] all = { 1, 2, 4 };
            var all_result=all.All(x=>x<4);
            string[] country_arr_contains = { "india", "USA", "ameria", "usa", "INDIA" };
            var result_contains = country_arr_contains.Contains("usa", StringComparer.OrdinalIgnoreCase);
            #endregion

            //for complex object duplicate value find we can use distinct

            #region Sequential operator 
            //whether two list elements are equal to check
            int[] seq1 = { 1, 2, 4 };
            int[] seq2 = { 1, 2, 4,5 };

            var result_seq= seq1.SequenceEqual(seq2);


            #endregion

            #region concat operator (combine two list into single list)

            int[] combine1 = { 1, 2, 3, 4 };
            int[] combine2 = { 5, 6, 7, 8 };
            var concatresult=combine1.Concat(combine2);

            #endregion

            #region Generation Operator
            //range operator
            var even_numer =Enumerable.Range(1,10).Where(x => x%2==0);

            //Repeat
            var repeat=Enumerable.Repeat(even_numer,10);

            var dataenum = Enumerable.Empty<int>();
            foreach(var item in dataenum)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region set operators 
            //Distinct: only unique values return
            //union : two collection values combine into one collection and remove duplicate
            //interspect: common values retive from both list
            //except: list 2 values except list1 values get

            string[] country_arr_uni = { "india", "USA", "ameria", "usa", "INDIA" };
            string[] country_arr1_uni = { "newzealnd", "USA", "japan", "united kingtom" };
            var final_union= country_arr_uni.Union(country_arr1_uni,StringComparer.OrdinalIgnoreCase);

            var final_intercept = country_arr_uni.Intersect(country_arr1_uni);
            var final_except=country_arr_uni.Except(country_arr1_uni,StringComparer.OrdinalIgnoreCase);

            string[] country_arr = { "india", "USA", "ameria", "usa", "INDIA" };

            var country_arr2_distinct_notunique = country_arr.Distinct().ToList();
            var country_arr2_distinct = country_arr.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
            List<Employee> employees_distinct = new List<Employee>()
            {
                new Employee(){EmployeeId=1,EmployeeName="mari"},
                new Employee(){EmployeeId=1,EmployeeName="mari"},
                new Employee(){EmployeeId=3,EmployeeName="ravi"},
            };
            var distinct_emp_duplicate = employees_distinct.Distinct();
            var distinct_emp_dist = employees_distinct.Select(x=>new {x.EmployeeId,x.EmployeeName}).Distinct();

            #endregion

            #region cross join no need to matched id on both table

            var result_cross_sql = (from emp in EmployeeDepartment.GetallEmployeeDepartment()
                                  from dept in Department.getAlldepartments()
                                  select new { emp, dept }).ToList();

            var result_cross_linq = EmployeeDepartment.GetallEmployeeDepartment().
                SelectMany(e=>Department.getAlldepartments(), (e, d) => new
                {
                    e
                     ,
                    d
                });
            #endregion


            #region Left outer join / left join
            var result_leftjoin = from emp in EmployeeDepartment.GetallEmployeeDepartment()
                                  join dep in Department.getAlldepartments()
                                  on emp.DepartmentId equals dep.Id into egroup
                                  from d in egroup.DefaultIfEmpty()
                                  select new
                                  {
                                      Id = emp.EmployeeId,
                                      Name = emp.EmployeeName,
                                      DepartmentName = d?.Name
                                  };

            #endregion


            ///summary inner join vs group join
            ///both we can use join in sql query format 
            ///in linq we can use join and group join keyword
            ///group join have into keyword inner join no need to use into keyword
            ///group join provide the hierarcial data bu inner join provide the combined two table data 

            #region inner join

            var result_inner = EmployeeDepartment.GetallEmployeeDepartment().Join(Department.getAlldepartments(), e => e.DepartmentId, d => d.Id, (employee, depart) => new
            {
                Name = employee.EmployeeName,
                department = depart.Name
            }) ;

            var resultinner_sql = from emp in EmployeeDepartment.GetallEmployeeDepartment()
                                  join depart in Department.getAlldepartments()
                                  on emp.DepartmentId equals depart.Id 
                                  select new
                                  {
                                      Name=emp.EmployeeName,
                                      DepartmentName=depart.Name,

                                  };
            #endregion

            #region group join produces the hierarichal data structure
            var employessdepartment = Department.getAlldepartments().
                                    GroupJoin(
                                            EmployeeDepartment.GetallEmployeeDepartment(),
                                            d => d.Id,
                                            e => e.DepartmentId,
                                            (deportment, employee) => new
                                            {
                                                department=deportment,
                                                employee=employee,
                                            }
                                            );

            //Alterate way
            var employessdepartmentsql = from d in Department.getAlldepartments()
                                         join e in EmployeeDepartment.GetallEmployeeDepartment()
                                         on d.Id equals e.DepartmentId into empdept
                                         select new
                                         {
                                             department = d,
                                             employee = empdept
                                         };


            #endregion

            #region Element operator 
            var first = Employee.GetallEmployees().First(x=>x.Gender=="Other");// if any null value thorw exception sequence contain no elements
            var firstordefault = Employee.GetallEmployees().FirstOrDefault(); // if no elements on sequence or the condition is not satisfied
            var last = Employee.GetallEmployees().Last(x => x.Gender == "Other");// if any null value thorw exception sequence contain no elements
            var lastordefault = Employee.GetallEmployees().LastOrDefault(x => x.Gender == "Other"); // if no elements on sequence or the condition is not satisfied
            var signle = Employee.GetallEmployees().Single(); // in our sequence contain only on element we can use and  if any null values/more than one value its throw exception
            var singleordefault = Employee.GetallEmployees().SingleOrDefault(x=>x.Gender=="Male");// if no elements on sequence or the condition is not satisfied and more than elementa
            var defaultorempty = Employee.GetallEmployees().DefaultIfEmpty(new Employee() { }); //we can set default values if emplty values are come into that list

            #endregion

            #region max-repaat letter in world
            string maxrepat = "Hello world";
            var reprat = maxrepat.Replace(" ", "").GroupBy(x => x).Select(x => new { key = x.Key, count = x.Count() }).OrderByDescending(x => x.count).FirstOrDefault();
            #endregion

            #region group By multiple keys
            var employeeMultiKey = Employee.GetallEmployees().
                             GroupBy(x => new { x.Department, x.Gender }).
                             OrderBy(x => x.Key.Department).ThenBy(x => x.Key.Gender).
                             Select(x => new
                             {
                                 dept = x.Key.Department,
                                 gender = x.Key.Gender,
                                 employee = x.OrderBy(g => g.EmployeeName)
                             });

            var employeemultikeysql = from emp in Employee.GetallEmployees()
                                      group emp by new { emp.Department, emp.Gender } into egrop
                                      orderby egrop.Key.Department, egrop.Key.Gender
                                      select new
                                      {
                                          dept = egrop.Key.Department,
                                          gender = egrop.Key.Gender,
                                          employee = egrop.OrderBy(x => x.EmployeeName)
                                      };


            foreach (var data in employeeMultiKey)
            {
                Console.WriteLine($"Department {data.dept}-- Gender  {data.gender} -- employname {data.employee.Count()}");
            }

            #endregion

            #region Group by single keys
            //one way
            var employeeGroups = Employee.GetallEmployees().GroupBy(x => x.Department);

            //another way
            var employeegrps = from emp in Employee.GetallEmployees()
                               group emp by emp.Department into egroup
                               orderby egroup.Key
                               select new
                               {
                                   key = egroup.Key,
                                   Employees = egroup.OrderBy(x => x.EmployeeName),
                               };


            foreach (var group in employeeGroups)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Count(x => x.Gender == "Male"));
                Console.WriteLine("{0} - {1}", group.Key, group.Max(x => x.salary));
            }

            #endregion

            Console.ReadKey();
        }
    }
}
