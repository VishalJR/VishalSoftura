using System;
class caltax1
{
public void calVAT()
{
int price;
float VAT,pt;
Console.WriteLine("Price:");
VAT=(price*20)/100;
pt=VAT+price;
Console.WriteLine("Total Amount after VAT:"+pt);
}
}
class caltax2:caltax1
{
public void calGST(int price)
{
float GST,pt0;
GST=(price*12)/100;
pt0=GST+price;
Console.WriteLine("Total Amount after GST:"+pt0);
}
}
class inherit1
{
public static void main()
{
caltax1 obj=new caltax1();
caltax2 obj1=new caltax2();
obj.calVAT();
obj1.calGST(price);
}
}

