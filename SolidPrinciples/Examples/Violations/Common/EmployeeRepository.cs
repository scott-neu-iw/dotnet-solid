using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Examples.Violations.Common
{
    public class EmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository()
        {
            var connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            _context = new DataContext(connString);
        }

        public object Getemployee(int employeeId)
        {
            // do lookup
            return new object();
        }
    }
}
