using EmployeeDepartmentMentorTask.Models;
using System;
using System.Collections.Generic;
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

            if (Console.ReadLine() == "1") {
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
            Console.ReadLine();

        }
    }
}
