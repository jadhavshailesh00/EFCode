using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCode.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Salary { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Departments? Department { get; set; }


    }
}
