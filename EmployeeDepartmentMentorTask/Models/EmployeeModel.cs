using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartmentMentorTask.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        public int DepartmentId { get; set;  }

        public string Designation { get; set; }
        public string Name { get; set;  }
        public int Age { get; set; }
        public double Salary { get; set; }
        public DepartmentModel Department { get; set; }


        public EmployeeModel( string designation, string name, int age, double salary, DepartmentModel department)
        {
            Designation = designation;
            Name = name;
            Age = age;
            Salary = salary;
            Department = department;
        }
    }
}
