using System;

namespace Method
{
	class Program
	{
		static void Main(string[] args)
		{
				Console.Clear();

				Console.WriteLine("Enter Two Numbers:(Each number seperated by enter)");
				double n1 = Convert.ToDouble(Console.ReadLine());
				double n2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Multiplication is: " + Multi(n1,n2));

				Console.ReadKey();		
		}

		static double Multi(double n, double m)
		{
			return m*n;
		}
	}
}


