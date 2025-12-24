using System;

namespace Random_nummber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			Random random = new Random();
			int rn = random.Next(1,7);

			Console.WriteLine("Random number between 1 and 7 is: " + rn);
			
			double drn = random.NextDouble();
			Console.WriteLine("Random decimal number between 0 and 1 is:" + drn);

			Console.ReadKey();
		}
	}
}