using System;

namespace ObjArray
{
    class Program
    {
        static void Main()
        {
            //Declaration
            Phone[] shop = new Phone[3];
            //Objects
            Phone p1 = new Phone("IPhone");
            Phone p2 = new Phone("Samsung");
            Phone p3 = new Phone("OnePlus");
            //Initializetion/Assignment
            shop[0] = p1;
            shop[1] = p2;
            shop[2] = p3;
            foreach(Phone phone in shop)
            {
                Console.WriteLine(phone.Brand);
            }
            Console.WriteLine();
            //Declaration+Assignment
            Phone[] Chhshop = { new Phone("Nokiya"), new Phone("Micromax"), new Phone("Lava") };

            foreach (Phone phone in Chhshop)
            {
                Console.WriteLine(phone.Brand);
            }
        }



        
    }

    class Phone
    {
        public String Brand;
        public Phone(String brand)
        {
            this.Brand = brand;
        }
    }
}
