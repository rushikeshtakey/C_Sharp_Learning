using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name:");
            String name = Console.ReadLine();

            Console.WriteLine("What is your birth Year:");
            int birYar = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            Console.WriteLine(name + " Your age is: " +  (2025 - birYar) + "years");

            Console.ReadKey();

        }
    }
}