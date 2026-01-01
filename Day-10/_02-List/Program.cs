using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> foods = new List<String>();
            foods.Add("Dosa");
            foods.Add("Samosa");
            foods.Add("Kachori");
            foods.Add("Kanda Bhaje");
            foods.Add("Misal Pav");
            foods.Add("Pav Bhaji");
            foods.Add("Wada Pav");
            foreach (String item in foods)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("foods.Remove(\"Dosa\")");
            foods.Remove("Dosa");
            foreach(String item in foods)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("foods.Insert(0, \"Wada Pav\")");
            foods.Insert(0, "Wada Pav");
            foreach (String item in foods)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(foods.Count());
            Console.WriteLine(foods.IndexOf("Wada Pav"));
            Console.WriteLine(foods.LastIndexOf("Wada Pav"));
            Console.WriteLine(foods.Contains("Samosa"));
            Console.WriteLine("foods.Sort()");
            foods.Sort();
            foreach (String item in foods)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("foods.Reverse()");
            foods.Reverse();
            foreach (String item in foods)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("foods.Clear()");
            foods.Clear();
            foreach (String item in foods)
            {
                Console.WriteLine(item);
            }

        }
    }
}