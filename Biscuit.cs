using System;
public class Arry5
{
public static void Main()
{
string[][]Store=new string[3][];
Store[0]=new string[]{"Oreo","Bourbon","Milano","Digestive"};
Store[1]=new string[]{"Dark Chocolate","White Chocolate","Belgian Chocolate","Caramel Chocolate","Nuts Chocolate"};
Store[2]=new string[]{"Beer","Rum","Scotch","Whisky","Wine"};
for(int i=0;i<Store.Length;i++)
{
	for(int j=0;j<Store[i].Length;j++)
	Console.Write(Store[i][j]+"\t");
	Console.WriteLine();


}
}
}