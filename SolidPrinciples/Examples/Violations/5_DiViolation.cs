using Examples.Violations.Common;

namespace Examples.Violations.Di
{
    /*
    High-level modules should not depend on low-level modules. Both should depend on abstractions.
    Abstractions should not depend on details. Details should depend on abstractions.
     */
    public class EmployeeReportService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeReportService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public string GetReport(int employeeId)
        {
            var employee = _employeeRepository.Getemployee(employeeId);
            return employee.ToString();
        }
    }
}
