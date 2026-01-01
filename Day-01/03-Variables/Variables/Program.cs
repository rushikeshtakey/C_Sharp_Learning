using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //Declaration
            x = 111;//initializetion

            int y = 222;// declaration + initializetion

            int z = x + y;

            int age = 21;
            double hight = 300.5;
            bool light = false;
            char at = '@';
            String name = "Rushikesh";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("Your age is "+ age);
            Console.WriteLine("Your hight is " + hight + "cm");
            Console.WriteLine("Lights on/off" + light);
            Console.WriteLine(at);
            Console.WriteLine("User Name: "+ at + name );

            Console.ReadKey();
        }
    }
}
