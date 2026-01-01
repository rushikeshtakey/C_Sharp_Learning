using System;

namespace ExceptionHandeling
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			
			int x;
			int y;
			
			try
			{
				Console.WriteLine("Enter 2 numbers: ");
				x = Convert.ToInt32(Console.ReadLine());
				y = Convert.ToInt32(Console.ReadLine());
			
				Console.WriteLine("Division is: " + (x/y));
			}
			catch(DivideByZeroException e)
			{
				Console.WriteLine("Can't Devide by zero");
			}
			catch(FormatException e)
			{
				Console.WriteLine("Please enter a number");
			}
			catch(Exception e)
			{
				Console.WriteLine("Something went wrong");
			}
			finally
			{
				Console.WriteLine("This is Finally block");
			}

			Console.WriteLine("Main ends");
			Console.ReadKey();
		}
	}
}


