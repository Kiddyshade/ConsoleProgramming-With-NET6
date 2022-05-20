// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Declare Fixed Array
int[] FixedArray=new int[4];

//Add value to Fixed size Array
FixedArray[0] = 1;
FixedArray[1] = 32;
FixedArray[2] = 22;
FixedArray[3] = 23;
for (int i = 0; i < FixedArray.Length; i++)
{
    Console.WriteLine(FixedArray[i]);
}

int[] grades = new int[] { 20, 34, 33, 32, 50, 70 };

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Enter grader");
    grades[i] = Int32.Parse(Console.ReadLine());
}
Console.WriteLine("The grades you have entered are");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

//Print value in Fixed size Array

//Declare variable Sized Array

//Add value to a variable sized Array

//Print Values in Variable Sized Array