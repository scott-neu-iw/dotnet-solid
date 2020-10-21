using Examples.Better.Constants;
using Examples.Better.Factories;
using Examples.Better.Repositories;

namespace Examples.Better.Services
{
    public class EmployeeReportService
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly IDataExportFactory _dataExportFactory;

        public EmployeeReportService(EmployeeRepository employeeRepository, IDataExportFactory dataExportFactory)
        {
            _employeeRepository = employeeRepository;
            _dataExportFactory = dataExportFactory;
        }

        public byte[] GetEmployeeReport(ExportType type, int employeeId)
        {
            var records = _employeeRepository.GetEmployeeReportRecords(employeeId);
            var exportSvc = _dataExportFactory.Create(type);
            return exportSvc.Export(records);
        }
    }
}
