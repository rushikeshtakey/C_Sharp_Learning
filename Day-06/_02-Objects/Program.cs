using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Enter 2 Numbers: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            MaxMin mn = new MaxMin();
            mn.n1 = n1;
            mn.n2 = n2;
            Console.WriteLine(mn.Max() + " is greater");
            Console.WriteLine(mn.Min() + " is smaller");

            Console.ReadKey();


        }

    }

}