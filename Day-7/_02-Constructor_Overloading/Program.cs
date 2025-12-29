using System;

namespace School
{
    class Fifth
    {
        static void Main()
        {
            Student s1 = new Student(123456789456, "Rushikesh", 22);
            Student s2 = new Student(45612378456123);
            Student s3 = new Student(123456789, "Chetan");

            Console.WriteLine("PRN of s1 is: " + s1.GetPRN());
            Console.WriteLine("PRN of s2 is: " + s2.GetPRN());
            Console.WriteLine("PRN of s3 is: " + s3.GetPRN());

        }


    }

    class Student
    {
        int rnum, age;
        long aadhar, id;
        String name;
        String PRN;
        public Student(long id,String name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.PRN = name+Convert.ToString(age)+ Convert.ToString(id);
        }

        public Student(long aadhar)
        {
            this.aadhar = aadhar;
            this.PRN = Convert.ToString(aadhar);
        }

        public Student(int rnum,String name)
        {
            this.rnum = rnum;
            this.name = name;
            this.PRN = Convert.ToString(rnum)+name;
        }

        public String GetPRN()
        {
            return this.PRN;
        }
    }
}