using System;
abstract class Membership
{
public abstract void package();
}
class Accomadation:Membership
{
public override void package()
{
Console.WriteLine("3days accomodation at Resort");
}
}
class Food:Membership
{
public override void package()
{
Console.WriteLine("5days accomodation at Resort & 2 Dinner on the house");

Console.WriteLine("7days accomodation at Resort & 5 Dinner on the house");
}
}
class absImple
{
public static void Main()
{
Accomadation obj =new Accomadation();
obj.package();
Food fobj=new Food();
fobj.package();

}
}