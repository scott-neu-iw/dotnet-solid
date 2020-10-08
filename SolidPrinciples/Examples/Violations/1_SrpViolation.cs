namespace Examples.Violations.SRP
{
    public class Employee
    {
        /*
        This means that every class, or similar structure, in your code should have only one 
        job to do. Everything in that class should be related to a single purpose. Our class 
        should not be like a Swiss knife wherein if one of them needs to be changed then the 
        entire tool needs to be altered. It does not mean that your classes should only 
        contain one method or property. There may be many members as long as they relate to 
        single responsibility.
         */

        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully inserted or not</returns>
        public bool InsertIntoEmployeeTable(Employee em)
        {
            // Insert into employee table.
            return true;
        }
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(Employee em)
        {
            // Report generation with employee data using crystal report.
        }
    }
}
