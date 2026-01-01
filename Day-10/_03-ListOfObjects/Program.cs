using System;

namespace ListOfObjects
{
    class program
    {
        static void Main()
        {
            List<String> students = new List<String>();

            char Continue = 'y';

            do
            {
                Console.WriteLine("Enter Students name as per role number");
                students.Add(new (Console.ReadLine()));
                Console.WriteLine("Do you want to continue (y/n)");
                Continue = Convert.ToChar(Console.ReadLine());
            } while (Continue == 'y');

            Console.WriteLine("total students are: " + students.Count());
        }
    }

    class Student
    {
        String name;
        public Student(String name)
        {
            this.name = name;
        }
    }
}