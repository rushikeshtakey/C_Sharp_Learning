using System;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Animals animal = new Animals();
            Dogs dog = new Dogs();
            Cats cat = new Cats();

            animal.Sound();
            dog.Sound();
            cat.Sound();

            Console.ReadKey();
        }
    }

    class Animals
    {

        public virtual void Sound() 
        {
            Console.WriteLine("animel sound");
        }

    }

    class Dogs : Animals
    {
        public override void Sound()
        {
            Console.WriteLine("bhau-bhau");
        }
    }

    class Cats : Animals 
    {
        public override void Sound()
        {
            Console.WriteLine("meow-meow");
        }

    }
}