using System;

namespace MethodOverloding
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

			Console.WriteLine("Multiplication of 5.5,4.2.3.21 is: " + Mult(5.5,4.2,3.21));
			Console.WriteLine("Multiplication of 5.5,4.2.3.21,22.88 is: " + Mult(5.5,4.2,3.21,22.88));
			Console.WriteLine("Multiplication of 5.5,4.2.3.21,22.88,78.32 is: " + Mult(5.5,4.2,3.21,22.88,78.32));			

			Console.ReadKey();
		}
		
		static double Mult(double a, Double b)
		{
			return a*b;	
		}

		static double Mult(double a, Double b, Double c)
		{
			return a*b*c;	
		}

		static double Mult(double a, Double b,double c, Double d)
		{
			return a*b*c*d;	
		}

		static double Mult(double a, Double b,double c, Double d, Double e)
		{
			return a*b*c*d*e;	
		}

		static double Mult(double a, Double b,double c, Double d, Double e, Double f)
		{
			return a*b*c*d*e*f;	
		}
	}
}

