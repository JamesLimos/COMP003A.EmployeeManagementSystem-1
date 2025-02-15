namespace COMP003A.EmployeeManagementSystem_1
{
    internal class Employee
    {
        private string _employeeID;
        private string _firstName;
        private string _middleName = "";
        private string _lastName;
        private double _salary;

        public string EmployeeID
        {
            get { return _employeeID; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            { _firstName = value;}
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value ?? ""; }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input. Please put a valid number.");
                }
                _salary = value;
            }
        }
        public Employee(string EmployeeID, string FirstName, string LastName, double Salary, string MiddleName = "")
        {
            _employeeID = EmployeeID;
            _firstName = FirstName;
            _lastName = LastName;
            _middleName = MiddleName;
            _salary = Salary;
        }
        public void PrintFullName()
        {
            if (string.IsNullOrWhiteSpace(MiddleName))
            {
                Console.WriteLine($"Employee ID: {EmployeeID}");
                Console.WriteLine($"Name: {FirstName} {LastName}");
            }
            else
            {
                Console.WriteLine($"Employee ID: {EmployeeID}");
                Console.WriteLine($"{FirstName} {(string.IsNullOrWhiteSpace(MiddleName) ? "" : MiddleName + "")} {LastName}");
            }
        }
        public void DisplayEmployeeInfo()
        {
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary}");
        }
    }
}

