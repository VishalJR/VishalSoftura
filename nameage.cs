using System;
class A
{
public void ages()
{
int age;
Console.WriteLine("Enter your age:");
age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Age is:"+age);
}
}
class B
{
public void names()
{
string name;
Console.WriteLine("Enter your name:");
name=Console.ReadLine();
Console.WriteLine("Name is:"+name);
}
}
class task
{
public static void Main()
{
A aobj =new A();
aobj.ages();
B bobj =new B();
bobj.names();
}
}

