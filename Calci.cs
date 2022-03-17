using System;
abstract class Calci
{
public abstract void OP();
}
class Add:Calci
{
public override void OP()
{
  int n1=20,n2=2;
  int res;
  res=n1+n2;
Console.WriteLine("Add:",res);
}
}
class Sub:Calci
{
public override void OP()
{
  int n1=20,n2=2; 
  int res;
  res=n1-n2;
Console.WriteLine("Sub:",res);
}
}
class Mul:Calci
{
public override void OP()
{
  int n1=20,n2=2;
  int res;
  res=n1*n2;
Console.WriteLine("Mul:",res);
}
}
class Div:Calci
{
public override void OP()
{
  int n1=20,n2=2;
  int res;
  res=n1/n2;
Console.WriteLine("Div:",res);
}
}
class absImple
{
public static void Main()
{

Add aobj=new Add();
aobj.OP();
Sub sobj=new Sub();
sobj.OP();
Mul mobj=new Mul();
mobj.OP();
Div dobj=new Div();
dobj.OP();
}
}
