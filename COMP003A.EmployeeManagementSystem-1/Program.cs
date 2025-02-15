using static COMP003A.EmployeeManagementSystem_1.Department;

namespace COMP003A.EmployeeManagementSystem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("EnterEmployeeID: ");
            string EmployeeID = Console.ReadLine();
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter Middle Name (Press Enter to skip): ");
            string MiddleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEmployee created succefully!\n");

            Employee myEmployee = new Employee(EmployeeID, FirstName, MiddleName, Salary, LastName);
            myEmployee.DisplayEmployeeInfo();

            HRDepartment HRDepartment = new HRDepartment();
            HRDepartment.GetDepartmentDetails();
            HRDepartment.DisplayDepartmentInfo();
            HRDepartment.Operate();

            ITDepartment ITDepartment = new ITDepartment();
            ITDepartment.GetDepartmentDetails();
            ITDepartment.DisplayDepartmentInfo();
            ITDepartment.Operate();

        }
    }
}
