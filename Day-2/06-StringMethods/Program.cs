using System;

namespace StringMethod
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			String name = "Rushikesh Takey";
			
			Console.WriteLine(name.ToUpper());
			Console.WriteLine(name.ToLower());

			String phoneNumber = "9595-404-211";
			Console.WriteLine(phoneNumber.Replace("-",""));

			Console.WriteLine(name.Insert(0,"Mr. "));
			Console.WriteLine("First Name: " + name.Substring(0,10));
			Console.WriteLine("Last Name: " + name.Substring(10,5));

			Console.WriteLine("Length of Name: " + name.Length);
			
			Console.ReadKey();
		}
	}
}



