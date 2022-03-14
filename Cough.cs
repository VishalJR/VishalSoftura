using System;
public class CovidCare
{
public static void Main()
{
string name;
string TH;
string T;
string CS;
Console.WriteLine("Enter your Name:");
name=Console.ReadLine();
Console.WriteLine("Travel history ?");
TH=Console.ReadLine();
if(TH=="yes")
{
Console.WriteLine("Temperature ?");
T = Console.ReadLine();
if(T=="yes")
{
Console.WriteLine("Do you have cough and sneez ?");
CS = Console.ReadLine();
if(CS == "yes")
{
Console.WriteLine("Swab Test");
}
else
Console.WriteLine("28 days Quarantine and Medicine");
}
else
Console.WriteLine("Home Quarantine");
}
else
{
Console.WriteLine("No covid u r Safe");
}
}
}

	