using EmployeeDepartmentMentorTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartmentMentorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //! task1
            EmployeeDepartmentContext context = new EmployeeDepartmentContext();


            //! Deparment Also Added.
            string choice = Console.ReadLine();

            if (choice == "0")
            {
                context.Employees.Add(new 
                    EmployeeModel("Senior Software Engineer", "Mani", 22, 
                        20000, new DepartmentModel("Software")));
                context.Employees.Add(new
                    EmployeeModel("Senior Associate", "Vijay", 24,
                        25000, new DepartmentModel("Software")));

                context.Employees.Add(new
                    EmployeeModel("HR Executive", "Arun", 25,
                        40000, new DepartmentModel("HR")));

                context.Employees.Add(new
                    EmployeeModel("Marketing Manager", "Arul", 26,
                        25000, new DepartmentModel("Marketing")));

                context.Employees.Add(new
                    EmployeeModel("Senior Software Engineer", "Ram", 22,
                        18000, new DepartmentModel("Software")));
                context.SaveChanges();

            }
            else if ( choice == "1") {
                Console.WriteLine("In if");
                try
                {
                    context.Employees.Add(new EmployeeModel("System Admin", "Venkat", 21, 15000, new DepartmentModel("Hardware")));
                    context.SaveChanges();
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
                
            }
            else if (choice == "2")
            {
                Console.WriteLine("In 2");

                var allEmployee = (from e in context.Employees where e.Designation == "Senior Associate"
                    select e ).ToList<EmployeeModel>();

                //var list = allEmployee.ToList<EmployeeModel>(;

                //Console.WriteLine(allEmployee.GetType());

                foreach (var employee in allEmployee)
                {
                    employee.Salary += 2000;
                    context.Entry(employee).State = EntityState.Modified;

                }
                
                //context.Entry(allEmployee).State = EntityState.Modified;
                context.SaveChanges();
            }else if (choice == "3")
            {
                var allEmployee = (from e in context.Employees
                    where e.Designation == "Senior Software Engineer"
                    select e).ToList<EmployeeModel>();
                double salarySum = 0;
                foreach (var employee in allEmployee)
                {
                    salarySum += employee.Salary;
                }

                Console.WriteLine("Salary Sum is: "+salarySum);
            }

            Console.ReadLine();
        }
    }
}
