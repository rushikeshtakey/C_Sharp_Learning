using System;

namespace Math_class
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.Clear();

			int num = 4;
			Console.WriteLine("Square root of 4 is: " + Math.Sqrt(num));
			Console.WriteLine("Cube of 4 is: " + Math.Pow(num,3));
			
			int mnum = -4;
			Console.WriteLine("Absolute value of -4 is: " + Math.Abs(mnum));
			
			double rnum = 3.14;	
			Console.WriteLine("Rounding of 3.14: " + Math.Round(rnum));	

			double cnum = 3.14;
			Console.WriteLine("Ceiling value of 3.14: " + Math.Ceiling(cnum));

			double fnum = 3.99;
			Console.WriteLine("Floor value of 3.99: " + Math.Floor(fnum));

			int m = 5;
			int n = 4;
			
			Console.WriteLine("Max value between 5 and 4 is:" + Math.Max(m,n));
			Console.WriteLine("Small value between 5 and 4 is:" + Math.Min(m,n));

			Console.ReadKey();
				
		}
	}
}