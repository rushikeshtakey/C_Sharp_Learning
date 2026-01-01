using System;

namespace Arithmatic_operators
{

	class Program
		{
			static void Main (string[] args)
				{
					Console.WriteLine("Arithmatic operators:");

					//Addition operator:
					int age = 22;
					Console.WriteLine("My age is"+ age);
					age = age + 2;
					//OR
					age += 2;
					Console.WriteLine("My age now"+ age +"\n");

					//Increment operator:
					age = 22;
					Console.WriteLine("My age is"+ age);
					age = age + 1;
					//OR
					age +=1;
					//OR	
					age++;
					Console.WriteLine("My age now"+ age+"\n");
					
					//Subtraction operator:
					age = 22;
					Console.WriteLine("My age is"+ age);
					age = age -2;
					//OR
					age -=2;
					Console.WriteLine("My age now"+ age+"\n");
					
					//Decrement operator:
					age = 22;
					Console.WriteLine("My age is"+ age);
					age = age - 1;
					//OR
					age -=1;
					//OR	
					age--;
					Console.WriteLine("My age now"+ age+"\n");
					
					//Multiplicetion operator:
					age = 22;
					Console.WriteLine("My age is"+ age);
					age = age *2;
					//OR
					age *=2;
					Console.WriteLine("My age now"+ age+"\n");
					
					//Division operator:
					age = 22;
					Console.WriteLine("My age is"+ age);
					age = age /2;
					//OR
					age /=2;
					Console.WriteLine("My age now"+ age+"\n");
					
					//Modulas operator:
					age = 22;
					Console.WriteLine("My age is"+ age);
					age = age % 6;
					//OR
					age %=3;
					Console.WriteLine("My age now"+ age+"\n");
					
					Console.ReadKey();
				}

		}


}