using System;

namespace Polymorphisum
{
    class Program
    {
        static void Main()
        {
            Phone dp = new Phone("Moto G40 fusion",8,128);
            Laptop dl = new Laptop("ASUS Vivobook",16,512);
            SmartWatch dsw = new SmartWatch("Samsung",3,32);
            DegitalDevice[] degitalDevices = { dp,dl,dsw};

            foreach(DegitalDevice device in degitalDevices) 
            {
                device.RamNStorage();
            }

        }
    }

    class DegitalDevice
    {

        public virtual void RamNStorage()
        { }

    }

    class Phone : DegitalDevice
    {
        String brand;
        int ram, storage;

        public Phone(String brand,int ram, int storage)
        {
            this.brand = brand;
            this.ram = ram;
            this.storage = storage;
        }
        public override void RamNStorage()
        {
            Console.WriteLine($"this {brand} has {ram}GB of ram and {storage}GB of storage.");
        }
    }

    class Laptop : DegitalDevice
    {
        String brand;
        int ram, storage;

        public Laptop(String brand, int ram, int storage)
        {
            this.brand = brand;
            this.ram = ram;
            this.storage = storage;
        }
        public override void RamNStorage()
        {
            Console.WriteLine($"this {brand} has {ram}GB of ram and {storage}GB of storage.");
        }
    }

    class SmartWatch : DegitalDevice
    {
        String brand;
        int ram, storage;

        public SmartWatch(String brand, int ram, int storage)
        {
            this.brand = brand;
            this.ram = ram;
            this.storage = storage;
        }
        public override void RamNStorage()
        {
            Console.WriteLine($"this {brand} has {ram}GB of ram and {storage}GB of storage.");
        }
    }

}