using System;

namespace ObjPassing
{
    class Program
    {
        static void Main()
        {
            Laptop l1 = new Laptop("Asus",16);
            Laptop l2 = Copy(l1);

            Console.WriteLine(l2.Brand + " " + l2.ram + "GB ram");
        }

        static public Laptop Copy(Laptop lp)
        {
            return new Laptop(lp.Brand,lp.ram);
        }
    }


    class Laptop
    {
        public String Brand;
        public sbyte ram;
        public Laptop(String Brand, sbyte ram) 
        {
            this.Brand = Brand;
            this.ram = ram;
        }
    }
}