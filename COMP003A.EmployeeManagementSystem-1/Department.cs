namespace COMP003A.EmployeeManagementSystem_1
{
    /// <summary>
    /// Represents the department with an abstract method
    /// </summary>
    abstract class Department
    {
        public string DepartmentName { get; set; }
        public abstract string GetDepartmentDetails();
        /// <summary>
        /// displays the department information
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }

        /// <summary>
        /// Represents the HRDepartment derived from Department.
        /// </summary>
        public class HRDepartment : Department, IDepartmentOperations
        {
            public HRDepartment()
            {
                DepartmentName = "Human Resources";
            }
            public override string GetDepartmentDetails()
            {
                return "Handles employee relations and recruitment.";
            }
            public void Operate()
            {
                Console.WriteLine("Performing HR operations...");
            }
        }
        /// <summary>
        /// Represents the ITDepartment derived from Department.
        /// </summary>
        public class ITDepartment : Department, IDepartmentOperations
        {
            public ITDepartment()
            {
                DepartmentName = "IT";
            }
            public override string GetDepartmentDetails()
            {
                return "Manages technical resources and infrastructure.";
            }
            public void Operate()
            {
                Console.WriteLine("Performing IT operations...");
            }
        }
    }
    /// <summary>
    /// Method for Operations
    /// </summary>
    interface IDepartmentOperations
    {
         void Operate();
    }
}
