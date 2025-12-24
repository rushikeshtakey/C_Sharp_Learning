using System;

namespace IfElseStatement
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();

			Console.WriteLine("What is your age: ");
			int age = Convert.ToInt32(Console.ReadLine());

			if(age<=0)
			{
				Console.WriteLine("First Learn to Walk");	
			}
			else if(age>=18)
			{
				Console.WriteLine("Can Vote");
			}
			else
			{
				Console.WriteLine("Can't Vote");
			}
			
			Console.ReadKey();
		}
	}
}