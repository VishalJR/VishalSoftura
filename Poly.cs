using System;
class Polytask
{
public void validate1()
{
Console.WriteLine("Enter Email Id");
string email=Console.ReadLine();
Console.WriteLine("Enter password");
string pass=Console.ReadLine();
Console.WriteLine("Validation done");
}
public void validate1(string mem,long pin)
{
Console.WriteLine("Membership Id is:"+mem);
Console.WriteLine("Pin is:"+pin);

Console.WriteLine("validation Done");
}
public void validate1(long mob,long pin)
{
Console.WriteLine("Mobile Number is:"+mob);
Console.WriteLine("Pin is:"+pin);
Console.WriteLine("validation Done");
}

public static void Main()
{
Polytask obj=new Polytask();
obj.validate1();
obj.validate1("MaxStevens",12325);
obj.validate1(8248030917,54821);
}
