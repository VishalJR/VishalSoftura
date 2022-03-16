using System;
class VAT
{
public virtual void calculateTax(int price)
{
int value;
value=price*20/100;
Console.WriteLine("VAT:"+value);
}
}
class GST:VAT
{
public override void calculateTax(int price)
{
int value;
value=price*12/100;
Console.WriteLine("GST:"+value);
}
}
class Inherit
{
public static void Main()
{
int price;
Console.WriteLine("price is:");
price=Convert.ToInt32(Console.ReadLine());
VAT obj=new VAT();
obj.calculateTax(price);
GST obj1=new GST();
obj1.calculateTax(price);
}
}
