using System;

namespace ForLoop
{
	class Program
	{
		public static void Main(string[] args)
		{
			//print odd numbers from 3 to given input
			Console.Clear();

			Console.WriteLine("Enter a number greater than 3: ");
			int num = Convert.ToInt32(Console.ReadLine());

			for(int i = 3; i<= num; i+=2)
			{
				Console.WriteLine(i);
			}

			Console.ReadKey();
		}
	}
}

