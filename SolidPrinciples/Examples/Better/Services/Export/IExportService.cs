using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Better.Services.Export
{
    public interface IExportService
    {
        byte[] Export<T>(IEnumerable<T> items);
    }
}
