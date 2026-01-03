using System;
using System.Threading;

namespace Multithreding
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Thread thread1 = new Thread(p.CountUp);
            Thread thread2 = new Thread(p.CountDown);
            thread1.Start();
            thread2.Start();

        }

        public void CountUp()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is Thread 1: " + i);
                Thread.Sleep(1000);
            }
        }
        public void CountDown()
        {
            for(int i = 10; i >=0; i--)
            {
                Console.WriteLine("This is Thread 2: " + i);
                Thread.Sleep(1000);
            }
        }
    }


}