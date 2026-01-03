using System;

namespace AutoImplementedPropery
{
    class Program
    {
        public static void Main()
        {
            Car car = new Car("Nano");
            Console.WriteLine(car.Model);
        }
    }

    class Car
    {
        public String Model { get; set; }
        public Car(String model)
        {
            this.Model = model;
        }
    
    }

}