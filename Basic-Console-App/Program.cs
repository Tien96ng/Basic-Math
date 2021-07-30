using System;

namespace Basic_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            Person jim = new Person("Jim", 23, "Male");

            jim.Introduction();
            Console.WriteLine("Hello World!");
            Console.WriteLine(m.AddTwo(10, 1));
        }
    }
}
