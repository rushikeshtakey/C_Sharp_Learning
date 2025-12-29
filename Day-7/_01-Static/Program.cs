using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Students p1 = new Students("Rushi");
            Students p2 = new Students("Pruthvi");
            Students p3 = new Students("Chetan");

            Console.WriteLine("Number of student present: " + Students.Present());

            Teacher.GetName("Swati Madam");
            Teacher.GetName("Shreya Madam");
            Teacher.GetName("Kadam Sir");

            Teacher.ShowNames();
            Console.WriteLine("Count of theachers present today " + Teacher.Count);

        }
    }

    //Static class
    class Students
    {
        String name;
        static int Count;

        public Students(String n)
        {
            this.name = n;
            Count++;
        }

        public static int Present()
        {
            return Count;
        }
    }

    static class Teacher
    {
        static String[] tNames = new string[5];
        public static int Count;
        static public void GetName(String name)
        {
            tNames[Count] = name;
            Count++;

        }
        static public void ShowNames()
        {
            for(int i=0; i<Count;i++)
            {
                Console.WriteLine(tNames[i]);
            }
        }

    }

}
