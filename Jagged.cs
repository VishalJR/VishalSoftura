using System;
public class Arry5
{
public static void Main()
{
string[][]Store=new string[3][];
Store[0]=new string[]{"Biscuit","Biscuit","Biscuit","Biscuit"};
Store[1]=new string[]{"Chocolate","Chocolate","Chocolate","Chocolate","Chocolate"};
Store[2]=new string[]{"Drinks","Drinks","Drinks","Drinks","Drinks"};
for(int i=0;i<Store.Length;i++)
{
	for(int j=0;j<Store[i].Length;j++)
	Console.Write(Store[i][j]+"\t");
	Console.WriteLine();


}
}
}