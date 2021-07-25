using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartmentMentorTask.Models
{
    public class DepartmentModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public string BusineesLine { get; set; }

        public ICollection<EmployeeModel> Emloyees { get; set; }

        public DepartmentModel(string departmentName)
        {
            DepartmentName = departmentName;
        }
    }
}
