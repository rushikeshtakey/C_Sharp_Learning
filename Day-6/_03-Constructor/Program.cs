using System;

namespace Constructor
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Enter your Id, name, phone and age");
            int id = Convert.ToInt32(Console.ReadLine());
            String name = Console.ReadLine();
            String phone = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            Student s1 = new Student(id, name, phone, age);
            s1.ShowInfo();

            Console.ReadKey();
        }

    }

    class Student
    {
        int Id;
        String name;
        String phone;
        int age;

        public Student(int id, string name, string phone, int age)
        {
            Id = id;
            this.name = name;
            this.phone = phone;
            this.age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("ID Number: " +  Id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone Number: " + phone);
        }
    }

}
