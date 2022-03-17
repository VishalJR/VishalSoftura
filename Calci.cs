using System;
abstract class calculator
{
public abstract void operations();
}
class arith:calculator
{
public override void operations()
{
int num1,num2,add,sub,mul,div;
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());
add=num1+num2;
sub=num1-num2;
mul=num1*num2;
div=num1/num2;
Console.WriteLine("Add the number:"+add);
Console.WriteLine("sub the number:"+sub);
Console.WriteLine("Mul the number:"+mul);
Console.WriteLine("Mul the number:"+div);
}
}

class absImple
{
public static void Main()
{
arith obj =new arith();
obj.operations();

}
}
