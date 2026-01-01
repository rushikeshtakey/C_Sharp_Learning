using System;

namespace Array
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();

			//Array Declaration + Initializetion
			String[] phones = {"Samsung", "Iphone", "Oneplus", "Nothing", "Motorola"};

			//Array Declaration
			String[] Laptops = new string[5];

			//Array Initializetion
			Laptops[0] = "Asus";
			Laptops[1] = "Linovo";
			Laptops[2] = "Macbook";
			Laptops[3] = "Hp";
			Laptops[4] = "Dell";

			//Updating array
			phones[4] = "Vivo";
			Laptops[3] = "Aser";

			//Iterating Array with For loop
			for(int i = 0; i < phones.Length; i++)
			{
				Console.WriteLine(phones[i]);
			}

			Console.WriteLine();

			foreach(String lap in Laptops)
			{
				Console.WriteLine(lap);
			}

			Console.ReadKey();
		}
	}
}

