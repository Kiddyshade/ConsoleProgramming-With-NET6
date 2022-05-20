// See https://aka.ms/new-console-template for more information

//Declaring
List<string> names=new List<string>();
string name = string.Empty;

//Adding name to the list
//names.Add("Naresh Kumar");

//making user to enter names

//while(name!= "-1")
//while(name.Equals("-1")==false)

while (!name.Equals("-1"))
{
    Console.Write("Enter your name :");
    name = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"You have inserted a name {name}");
       
    }
}

//printing the names
//using for loop
Console.WriteLine("For loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();

//using foreach
Console.WriteLine("Foreach Loop");
foreach (var item in names)
{
    Console.WriteLine(item);
}