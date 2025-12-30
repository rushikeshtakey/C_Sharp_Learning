using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Median median = new Median();
            //BubbleSort bs = new BubbleSort();// Cannot create an instance of the abstract type or interface 'BubbleSort'
            Console.WriteLine("Entet number of elements you are going to enter:");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter elements seperated by enter: ");
            for (int i = 0; i < len; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //bs.Sort(arr, len); not possible

            Console.WriteLine("Median is: " + median.GetMedian(arr, len));
        }
    }

    abstract class BubbleSort
    {
        public void Sort(int[] arr, int length)
        {
            for (int j = 0; j < length - 1; j++)
            {
                for (int i = 0; i < length - 1 - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }
    }

    class Median : BubbleSort
    {
        public double GetMedian(int[] arr, int length)
        {
            Sort(arr, length);

            if (length % 2 != 0)   
                return arr[length / 2];


            return (arr[length / 2] + arr[(length / 2) - 1]) / 2.0;
        }
    }

}