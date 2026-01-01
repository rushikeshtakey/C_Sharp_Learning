using System;

namespace MultidimentionalArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] Tables = {	
						{2,4,6,8,10},
						{3,6,9,12,14},
						{4,8,12,17,20}
					   };

			Tables[1,4] = 15;
			Tables[2,3] = 16;

			Console.WriteLine("Output from foreach loop:");
			foreach(int table in Tables)
			{
				Console.Write(table + " ");
			} 

			Console.WriteLine("\nOutput from for loop:");

			for(int i =0; i< Tables.GetLength(0); i++)
			{
				for(int j = 0; j<Tables.GetLength(1); j++)
				{
					Console.Write(Tables[i,j] + " ");
				}
				Console.WriteLine();
			}
			
		}
	}
}

