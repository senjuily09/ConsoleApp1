using System;

namespace ConsoleApp1
{
    internal class Practice
    {
        public string name;
        public int age;

        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

        static void Main(string[] args)
        {
            Practice obj1 = new Practice();
            obj1.name = "John";
            obj1.age = 20;
 
            Practice obj2 = new Practice();
            obj2.name = "Alice";
            obj2.age = 22;

            Practice obj3 = new Practice();
            obj3.name = "Bob";
            obj3.age = 25;

            obj1.Display();
            Console.WriteLine();

            obj2.Display();
            Console.WriteLine();

            obj3.Display();
        }
    }
}