using Examples.Better.Models;
using System.Collections.ObjectModel;

namespace Examples.Better.Repositories
{
    public class EfContext
    {
        public EfContext(string connectionString)
        {

        }

        public Collection<Employee> Employees { get; }
    }
}
