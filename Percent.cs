using System;
public class Marks
{
public static void Main()
{
string name;
int [] marks=new int []{70,70,70,70,70};
int total=0,percentage;
Console.WriteLine("Enter your Name:");
name=Console.ReadLine();	
for(int i=0;i<5;i++)
{
  total= total+marks[i];
}
Console.WriteLine("Total Marks of"+" "+name+"is:"+" "+total);
percentage=total/5;
Console.WriteLine("Percentage of "+name +" "+"is:"+percentage);
}
}
  
