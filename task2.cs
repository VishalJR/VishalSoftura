using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{


	class task2
	{


		public static void Main()
		{
			int eye = 52, Legs = 80;

			int count = 0;
			int count2 = 0;

			count = 2 * (eye)-(Legs);
			count = count / 2;

			Console.WriteLine("No of Ducks:"+count);

			count2 = 26 - count;
			Console.WriteLine("No of Goats:"+count2);
		}
	}

}
	


