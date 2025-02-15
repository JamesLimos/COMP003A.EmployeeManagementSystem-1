using static COMP003A.EmployeeManagementSystem_1.Department;

namespace COMP003A.EmployeeManagementSystem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("EnterEmployeeID: ");
            string employeeID = Console.ReadLine();
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Middle Name (Press Enter to skip): ");
            string middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Employee myEmployee = new Employee(employeeID, firstName, middleName, salary, lastName);
            myEmployee.DisplayEmployeeInfo();

            HRDepartment HRDepartment = new HRDepartment();
            HRDepartment.DisplayDepartmentInfo();
            HRDepartment.Operate();

            ITDepartment ITDepartment = new ITDepartment();
            ITDepartment.DisplayDepartmentInfo();
            ITDepartment.Operate();

        }
    }
}
