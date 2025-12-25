using System;

namespace NumberGuessingGame
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			char play = 'y';
			int num = 0;
			int guess = 0;
			Random random = new Random();

			do
			{
				num = random.Next(1,101);

				do
				{
					Console.WriteLine("Guess the number between 1-100");
					guess = Convert.ToInt32(Console.ReadLine());

					if (guess < num)
					{
						Console.WriteLine("Guess Greater");
					}
					else
					{
						Console.WriteLine("Guess Smaller");
					}
	
				}while(num != guess);

				Console.WriteLine(num+" is correct guess");
				
				Console.WriteLine("Do you want to play again:(y/n)");
				play = Convert.ToChar(Console.ReadLine());
	

			}while(play == 'y');

			Console.ReadKey();	



		}
	}
}

