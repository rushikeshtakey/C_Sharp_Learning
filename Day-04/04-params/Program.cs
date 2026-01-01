using System;

namespace Params
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			Mult(1,2,3);
			Mult(1,2,3,4,5);
			Mult(1,2,3,4,5,6);

			Console.ReadKey();
		}

		static void Mult(params int[] numbers)
		{
			int ans = 1;
			foreach(int number in numbers)
			{
				ans *= number;
			}

			Console.Write("Multiplication of ");

			foreach(int number in numbers)
			{
				Console.Write(number + " ");
			}

			Console.WriteLine("is " + ans);

		}
	}
}