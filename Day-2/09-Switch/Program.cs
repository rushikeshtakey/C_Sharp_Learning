using System;

namespace Switch
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			Console.WriteLine("Enter today's Date:");
			int date = Convert.ToInt32(Console.ReadLine());
			int isSeven = 99;
			if(date <=31 && date >0)
			{
				isSeven = date%7;
				Console.Write("Today's day is: ");

			}
			
			switch(isSeven)
			{
				case 0:
					Console.Write("Sunday");
					break;
				case 1:
					Console.Write("Monday");
					break;
				case 2:
					Console.Write("Tuesday");
					break;
				case 3:
					Console.Write("Wednesday");
					break;
				case 4:
					Console.Write("Thusday");
					break;
				case 5:
					Console.Write("Friday");
					break;
				case 6:
					Console.Write("Saturday");
					break;
				default:
					Console.Write("This is a wrong date for ");
					break;
			}
			Console.WriteLine(" December 2025");
			Console.ReadKey();
		}
	}
}
