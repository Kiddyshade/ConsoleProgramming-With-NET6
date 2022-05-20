

    internal class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }


        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public double GetSalary(double salary)
        {
            return salary;
        }

        public void GetMiddleName(string MiddleName)
        {
        if (!string.IsNullOrEmpty(MiddleName))
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
        }
        }
    public void GetAge()
    {
        Console.WriteLine(Age);
    }
    public void GetSalary()
    {
        Console.WriteLine(Salary);
    }
    }
