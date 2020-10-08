using System;

namespace Examples.Violations.ISP
{
    /*
    Clients should not be forced to depend upon interfaces that they do not use.
     */

    public interface IEmployee
    {
        string GetProjectDetails(int employeeId);

        string GetEmployeeDetails(int employeeId);
    }

    public class CasualEmployee : IEmployee
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        // May be for contractual employee we do not need to store the details into database.
        public string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }

    public class ContractualEmployee : IEmployee
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        // May be for contractual employee we do not need to store the details into database.
        public string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
