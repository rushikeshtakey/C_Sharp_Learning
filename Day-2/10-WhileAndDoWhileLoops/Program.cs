using System;

namespace WhileLoops
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();

			//While Loop Implimentation:

			String fname = "";

			while(fname == "")
			{
				Console.WriteLine("What is your first name:");
				fname = Console.ReadLine();
			}

			Console.Clear();

			//Do-While loop  implimentation:

			String lname = "";

			do
			{
				Console.WriteLine("What is your Last Name: ");
				lname = Console.ReadLine();
				
			}while(lname == "");

			Console.Clear();

			Console.WriteLine("Your Name is: " + fname + " " + lname);

			Console.ReadKey();
		}
	}
}


