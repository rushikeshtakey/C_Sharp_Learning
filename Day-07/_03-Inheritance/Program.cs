using System;

namespace Inheritance
{

	class Program
	{

		static void Main()
		{
			Car c = new Car();
			Bicycle bc = new Bicycle();
			Bike bi = new Bike();
			Ricksha r = new Ricksha();

			c.speed = 60;
			c.GO();
			Console.WriteLine("This vehical has " + c.wheels +" wheels");

			bc.speed = 60;
			bc.GO();
			Console.WriteLine("This vehical has " + bc.wheels +" wheels");

			bi.speed = 60;
			bi.GO();
			Console.WriteLine("This vehical has " + bi.wheels +" wheels");

			r.speed = 60;
			r.GO();
			Console.WriteLine("This vehical has " + r.wheels +" wheels");
		}

	}

	class Vehical
	{

		public int speed = 0;

		public void GO()
		{

			Console.WriteLine("this vehical is moving");

		}


	}

	class Car : Vehical
	{

		public int wheels = 4;	

	}

	class Bicycle : Vehical
	{

		public int wheels = 2;

	}

	class Bike : Vehical
	{

		public int wheels = 2;

	}

	class Ricksha : Vehical
	{

		public int wheels = 3;

	}


}



