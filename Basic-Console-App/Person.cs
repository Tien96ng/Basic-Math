using System;

namespace Basic_Console_App
{
    public class Person
    {
        private string Name;
        private int Age;
        private string Gender;


        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public void Introduction()
        {
            Console.WriteLine($"Hi my name is {Name}. I am {Age} and I indentify as a {Gender}!");
        }
    }
}
