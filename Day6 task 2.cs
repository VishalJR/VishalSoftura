using System;
public class Bill
{
public static void Main()
{
int unit,price,a;
Console.WriteLine("Enter Unit used:");
unit=Convert.ToInt32(Console.ReadLine());
if (unit<200)
{
Console.WriteLine("Total Price:Rs");
price=unit*2;	
Console.WriteLine(price);	
}
if (unit>=201 && unit<=350)
{
Console.WriteLine("Total Price:Rs");
a=unit-200;
price=400+(a*3);	
Console.WriteLine(price);	
}
if (unit>=351 && unit<=500)
{
Console.WriteLine("Total Price:Rs");
a=unit-350;
price=850+(a*5);
Console.WriteLine(price);
}
if (unit>501)
{
Console.WriteLine("Total Price:Rs");
a=unit-500;
price=1600+(a*7);
Console.WriteLine(price);
}
}
}
