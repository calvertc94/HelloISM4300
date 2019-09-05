using System;

namespace HelloISM4300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //This is a change with one line comment
            /*
             * This is a multi-line comment
             */
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name + " this is the console speaking");
        }
    }
}
