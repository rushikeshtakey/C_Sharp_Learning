using System;

namespace GetNSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 2000;
            Console.WriteLine("Speed of the car is " + car.Speed);
        }
    }

    class Car
    {
        private int speed;
        public Car()
        {
            Speed = speed;
        }

        public int Speed
        {
            get {  return speed; }
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}