using System.Collections.Generic;

namespace Examples.Better.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; }
    }
}
