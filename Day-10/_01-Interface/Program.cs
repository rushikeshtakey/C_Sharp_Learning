using System;

namespace Interface
{
    class Program
    {
        public static void Main()
        {
            int[] arr = {5,25,3,4,8,6,9,10,85,20 };
            LarNSml ls = new LarNSml();
            Console.WriteLine("Largest in arr is: " + ls.largest(arr));
            Console.WriteLine("Smallest in arr is: " + ls.smallest(arr));

        }
    }

    interface ILarge
    {
        int largest(params  int[] array);
    }

    interface ISmall
    {
        int smallest(params int[] array);
    }

    class LarNSml : ILarge, ISmall
    {
        public int largest(params int[] array)
        {
            int large = array[0];
            
            for (int i = 1; i< array.GetLength(0);i++)
            { 
                       large = (array[i]>large)?array[i]: large;     
            }

            return large;
        }

        public int smallest(params int[] array)
        {
            int small = array[0];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                small = (array[i] < small) ? array[i] : small;
            }

            return small;
        }
    }
}