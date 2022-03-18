using System;
class parent
{
	public void GetData()
	{
		Console.WriteLine("Enter the Employee Id provided:");
		int Id=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter your Name:");
		string Name=Console.ReadLine();
		Console.WriteLine("Enter your Gender(Male/Female/Transgen:");
		string Gen=Console.ReadLine();
		Console.WriteLine("Enter your Years of Experience:");
		int YOE=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Your employee Id is:"+Id);
		Console.WriteLine("Your name is"+Name);
		Console.WriteLine("Your Gender is"+Gen);
		Console.WriteLine("You have "+YOE+ "of experience");
	}
		public void SalCal()
	{
		Console.WriteLine("Enter the Salary:");
		int Sal=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Which department?(SM and PD)");
		string SC=Console.ReadLine();
		switch(SC)
		{
			case "SM":
			int bonus1=Sal/5;
			int res1=bonus1+Sal;
			Console.WriteLine("Your Total Salary is"+res1);
			break;
			case "PD":
			int bonus2=Sal/10;
			int res2=bonus2+Sal;
			Console.WriteLine("Your Total Salary is"+res2);
			break;
			default:
			break;
		}

	}
}
class SalaryCal:parent
{

	public static void Main()
	{

		SalaryCal obj=new SalaryCal();
		obj.GetData();
		
		obj.SalCal();

	}
}