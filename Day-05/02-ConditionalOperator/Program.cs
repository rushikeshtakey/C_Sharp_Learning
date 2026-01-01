using System;

namespace ConditionalOperator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Two Numbers:");
			int n1 =  Convert.ToInt32(Console.ReadLine());
			int n2 =  Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine($"Largest number between {n1} and {n2} is : {Max(n1,n2)}");
		}

		static int Max(int n1, int n2)
		{
			return ((n1>n2) ? n1 : n2);
		}
	}
}

