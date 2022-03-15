using System;
public class agename
{
public static void Main()
{
string package;
Console.WriteLine("Say the package you want to subscribe:");
package=Console.ReadLine();
switch(package)
{
case "package a":Console.WriteLine("The price of the pack is INR250"+"\n"+"Has the Following channels:"+"\n"+"1.South Special"+"\n"+"2.Children's Club"+"\n"+"3.Movies");
                 break;
case "package b":Console.WriteLine("The price of the pack is INR450"+"\n"+"Has the Following channels:"+"\n"+"1.News"+"\n"+"2.Sports"+"\n"+"3.Movies"+"\n"+"4.Regional-2");
                 break;
case "package c":Console.WriteLine("The price of the pack is INR350"+"\n"+"Has the Following channels:"+"\n"+"1.Discovery,History,National");
                 break;
}
}
}