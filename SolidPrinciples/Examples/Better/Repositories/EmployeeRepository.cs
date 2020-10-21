using Examples.Better.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.Better.Repositories
{
    public class EmployeeRepository
    {
        private readonly EfContext _context;

        public EmployeeRepository(EfContext context)
        {
            _context = context;
        }

        public Employee GetEmployee(int employeeId)
        {
            return _context.Employees.FirstOrDefault(i => i.EmployeeId == employeeId);
        }

        public IEnumerable<EmployeeReportRecord> GetEmployeeReportRecords(int employeeId)
        {
            return new List<EmployeeReportRecord>();
        }

    
    }
}
