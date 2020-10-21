using Examples.Better.Constants;
using Examples.Better.Services.Export;
using System;

namespace Examples.Better.Factories
{
    public interface IDataExportFactory
    {
        IExportService Create(ExportType type);
    }

    public class DataExportFactory : IDataExportFactory
    {
        public IExportService Create(ExportType type)
        {
            switch (type)
            {
                case ExportType.CrystalReports:
                    return new CrystalReportExportService();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
