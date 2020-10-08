using System;

namespace Examples.Violations.LSP
{
    /*
    The principle defines that objects of a superclass shall be replaceable with 
    objects of its subclasses without breaking the application. That requires the 
    objects of your subclasses to behave in the same way as the objects of your 
    superclass.
     */
    public abstract class Employee
    {
        public abstract string GetProjectDetails(int employeeId);

        public abstract string GetEmployeeDetails(int employeeId);
    }

    public class CasualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }

    public class ContractualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
