// See https://aka.ms/new-console-template for more information

Person person1 = new();
person1.FirstName = "Naresh";
person1.LastName = "Kumar";
person1.Age = 23;
person1.Salary = 2300;

Person person2 = new();
Console.WriteLine("Enter FirstName: ");
person2.FirstName = Console.ReadLine();
Console.WriteLine("Enter LastName: ");
person2.LastName = Console.ReadLine();
Console.WriteLine("Enter MiddleName: ");
string Midname = Console.ReadLine();
Console.WriteLine("Enter Age: ");
person2.Age = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter Salary: ");
person2.Salary= Int32.Parse(Console.ReadLine());


person2.GetFullName();
person2.GetMiddleName(Midname);
person2.GetAge();
person2.GetSalary();
Console.WriteLine("Age of the you "+DateUtil.YearofBirth(person2.Age));

