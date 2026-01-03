using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            double[] doubles = { 1.0, 2.0, 3.0 };
            String[] strings = { "1", "2", "3" };

            Show(ints);
            Show(doubles);
            Show(strings);
        }

        public static void Show<Thing>(Thing[] arr)
        {
            foreach(Thing thing in arr)
            {
                Console.Write(thing);
            }
            Console.WriteLine();
        }
    }


}