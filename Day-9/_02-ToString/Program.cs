using System;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Phone p1 = new Phone("MotoG fusion g40",8,"Snapdragon gen8",256);
            Console.WriteLine(p1.ToString());
            
            Console.ReadKey();
        }
    }

    class Phone
    {
        String brand;
        int ram;
        String Processor;
        int storage;

        public Phone(string brand, int ram, string processor, int storage )
        {   
            this.brand = brand;
            this.ram = ram;
            Processor = processor;
            this.storage = storage;
        }

        public override string ToString()
        {
            return ($"This is {brand} of {ram}GB ram.");
        }
    }

}