using System;

namespace NestedLoop
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();

			Console.WriteLine("Enter height: ");
			int h = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter width: ");
			int w = Convert.ToInt32(Console.ReadLine()); 
			Console.WriteLine("Enter symbol: ");
			char s = Convert.ToChar(Console.ReadLine());

			for(int i = 0; i < h; i++)
			{
				for(int j = 0; j < w; j++)
				{
					if(i==0 || i== h-1 || j==0 || j == w-1)
					{
						Console.Write(s);
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			
			

			Console.ReadKey();
		}
	}
}

