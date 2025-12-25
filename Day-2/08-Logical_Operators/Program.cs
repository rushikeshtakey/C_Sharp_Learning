using System;

namespace LogicalOperator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			Console.WriteLine("Enter three nimbers");
			int n1 = Convert.ToInt32(Console.ReadLine());
			int n2 = Convert.ToInt32(Console.ReadLine());
			int n3 = Convert.ToInt32(Console.ReadLine());
			
			if((n1>n2 && n1>n3)||(n1>n2 && n1==n3)||(n1==n2 && n1>n3))
			{
				Console.WriteLine(n1 + " Is gretest");
			}
			else if((n2>n1 && n2>n3)||(n2>n1 && n2==n3)||(n2==n1 && n1>n3))
			{
				Console.WriteLine(n2 + " Is gretest");
			}
			else if((n3>n1 && n3>n2)||(n3>n1 && n3==n2)||(n3==n1 && n3>n2))
			{
				Console.WriteLine(n3 + " Is gretest");
			}
			else
			{
				Console.WriteLine("All of them are equal");	
			}
			Console.ReadKey();
		}
	}
}