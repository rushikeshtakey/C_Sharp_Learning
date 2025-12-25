using System;

namespace Hypotenuse
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			
			Console.Write("Enter the value of side A: ");
			double A = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter the value of side B: ");
			double B = Convert.ToInt32(Console.ReadLine());

			Double H = Math.Sqrt(((A*A)+(B*B)));
			Console.Write("Hypotenuse is: " + H);			
			Console.ReadKey();
		}
	}
}