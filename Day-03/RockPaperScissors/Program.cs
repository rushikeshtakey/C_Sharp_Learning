using System;

namespace RockPaperScissors
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();

			//Variable declarations:
			char play = 'y';
			Random rand = new Random();
			String player;
			int com = rand.Next(1,4);
			String cpu;

			do
			{

				Console.WriteLine("Type:\nrock\npaper\nsecissors");
				player = Console.ReadLine();

				switch(com)
				{
					case 1:
						cpu = "rock";
						if(player == "rock")
						{
							Console.WriteLine("Draw\n");
						}												else if(player == "paper")
						{
							Console.WriteLine("Won\n");
						}
						else 
						{
							Console.WriteLine("Lost\n");
						}
					break;

					case 2:
						cpu = "paper";
						if(player == "rock")
						{
							Console.WriteLine("Lost\n");
						}												else if(player == "paper")
						{
							Console.WriteLine("Draw\n");
						}
						else 
						{
							Console.WriteLine("Won\n");
						}
					break;

					case 3:
																		cpu = "scissors";
						if(player == "rock")
						{
							Console.WriteLine("Won\n");
						}												else if(player == "paper")
						{
							Console.WriteLine("Lost\n");
						}
						else 
						{
							Console.WriteLine("Draw\n");
						}
						
					break;

					default:
							Console.WriteLine("Wrong input\n");
						
					break;
				}
				
																Console.WriteLine("Want to Play again: \n");
				play = Convert.ToChar(Console.ReadLine());			

			}while(play == 'y');

			Console.ReadKey();
		}
	}
}