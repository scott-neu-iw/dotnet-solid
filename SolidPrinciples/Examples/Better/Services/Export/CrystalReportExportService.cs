using System.Collections.Generic;

namespace Examples.Better.Services.Export
{
    public class CrystalReportExportService : IExportService
    {
        public byte[] Export<T>(IEnumerable<T> items)
        {
            return new byte[100];
        }
    }
}
