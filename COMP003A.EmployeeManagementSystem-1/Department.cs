namespace COMP003A.EmployeeManagementSystem_1
{
    public abstract class Department
    {
        public string DepartmentName { get; set; }
        public abstract string GetDepartmentDetails();
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }

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

    interface IDepartmentOperations
    {
        void Operate();
    }
}
