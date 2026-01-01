using System;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is a Write Method ");
            Console.WriteLine("This is a WriteLine method");

            //this is a single line comment
            /*
             this is a
             multiline
             comment
             */

            //using escape sequence

            Console.WriteLine("Formate specifier for (\\t)Tab->\t<-");
            Console.WriteLine("Formate specifier for (\\n)New line->\n<-");
            Console.WriteLine("Formate specifier for (\\b)Backspace->\b<-");
            Console.WriteLine("Formate specifier for (\\a)Bell alert sound->\a<-");
            Console.WriteLine("Formate specifier for (\\f) forward feed->\f<-");
            Console.WriteLine("Formate specifier for (\\r) carrage return->\r<-");
            Console.WriteLine("Formate specifier for (\\v) vertical tab->\v<-");
            Console.WriteLine("Escape sequence for back slash is backslash = \\\\");
            Console.WriteLine("Escape sequence for Double and single Quotes is backslash = \" Double and Single Quotes \'");

            Console.ReadLine();

        }
    }
}
