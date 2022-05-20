// See https://aka.ms/new-console-template for more information
//Empty DateTime
using System.Globalization;

DateTime date = DateTime.Now;
Console.WriteLine(date);

//Creating DateTime from a string
DateTime datetimefromstring = DateTime.Parse("12/1/1990", CultureInfo.InvariantCulture);
Console.WriteLine(datetimefromstring);