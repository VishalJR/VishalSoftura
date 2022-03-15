using System;  
public class MulTable 
{  
    public static void Main() 
{
   int i,n;
   
	Console.Write("\n\n");
    Console.Write("Display the multiplication table:\n");
    Console.Write("-----------------------------------");
    Console.Write("\n\n");   

   Console.Write("Input the number (Table to be calculated) : ");
   n= Convert.ToInt32(Console.ReadLine());   
   Console.Write("\n");
   for(i=1;i<=20;i++)
   {
     Console.Write("{0} X {1} = {2} \n",n,i,n*i);
   }
  }
}