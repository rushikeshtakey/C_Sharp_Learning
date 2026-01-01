using System;

namespace Type_Casting_and_Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constants = compile timed immutable value or read only
            const double pi = 3.14159;
            Console.WriteLine(pi);

            //Type Casting

            int a = Convert.ToInt32(pi);
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            int b = 111;
            double c = Convert.ToDouble(b);
            Console.WriteLine(c);
            Console.WriteLine(c.GetType());

            int d = 111;
            String e = Convert.ToString(b);
            Console.WriteLine(e);
            Console.WriteLine(e.GetType());

            String f = "f";
            char g = Convert.ToChar(f);
            Console.WriteLine(g);
            Console.WriteLine(g.GetType());

            String h = "True";
            bool i = Convert.ToBoolean(h);
            Console.WriteLine(i);
            Console.WriteLine(i.GetType());



            Console.ReadKey();
        }
    }
}
