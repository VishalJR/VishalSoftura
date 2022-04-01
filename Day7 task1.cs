using System;
public class agename
{
public static void Main()
{
string name;
int age;
Console.WriteLine("Name:");
name=Console.ReadLine();
Console.WriteLine("Age:");
age=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=age;i++)
{
  Console.WriteLine("Name:" +name+" "+"Age:"+age);
}
}
}
