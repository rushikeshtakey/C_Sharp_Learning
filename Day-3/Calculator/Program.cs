using System;

namespace Calculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			char ch = 'y';

			do
			{
				Console.WriteLine("Enter Two Numbers:");
				double n1 = Convert.ToDouble(Console.ReadLine());
				double n2 = Convert.ToDouble(Console.ReadLine());
				
				Console.WriteLine("Which operation do you want to Perform:");
				Console.WriteLine("Type:\n\t+ for Addition\n\t- for substration\n\t* for Multiplication\n\t/ for Division");
				char op = Convert.ToChar(Console.ReadLine());
				switch(op)
				{
					case '+':
						Console.WriteLine("Additions is: " + (n1+n2));
					break;
					case '-':
						Console.WriteLine("Subtraction is: " + (n1-n2));
					break;
					case '*':
						Console.WriteLine("Multiplicetion is: " + (n1*n2));
					break;
					case '/':
						Console.WriteLine("Division is: " + (n1/n2));
					break;
					default:
						Console.WriteLine("Wrong Input");
					break;
					
				}

				Console.WriteLine("Do you Want to Calculate again:(y/n): ");
				ch = Convert.ToChar(Console.ReadLine());
				
					
			}while(ch == 'y');
		}
	}
}


