using System;

namespace Enums
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32(Planets.Mercury));
            Console.WriteLine(Convert.ToInt32(Planets.Earth));

            PlanetSize ps  = new PlanetSize(); 
            ps.Volume = Convert.ToDouble(PlanetsRedus.Earth);
            Console.WriteLine("Volume of " + PlanetsRedus.Earth + " is: " + ps.Volume + "Km^3");

        }
    }

    enum Planets
    {
        Mercury = 1,
        Vinus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto

    }

    class PlanetSize
    {
        double volume;
        public PlanetSize()
        {
            
                Volume = volume;

        }

        public double Volume
        {
          
            get { return volume; } 
        
            set
            { volume = (4.0/3.0) * Math.PI * Math.Pow(value,3); }
        }
    
    }
    enum PlanetsRedus
    {
        Mercury = 2439,
        Vinus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }


}