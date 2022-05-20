// See https://aka.ms/new-console-template for more information
/* try
 * catch
 * finally
 * throw */
Console.WriteLine("Enter Number 1:");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter Number 2:");
int num2 = Int32.Parse(Console.ReadLine());

try
{
  

    int quotiant = num1 / num2;
    Console.WriteLine("Result" + quotiant.ToString());

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
  
}
finally
{
    Console.WriteLine("This is Finally block");
    

}