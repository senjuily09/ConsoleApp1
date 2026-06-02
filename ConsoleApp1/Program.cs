using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        string name = "";

        static void mymethod(string fname)
        {
            Console.WriteLine(fname + " world");
        }

        static void Main(string[] args)
        {
            // User Input
            Console.WriteLine("Enter User Name:");
            string username = Console.ReadLine() ?? "";

            Console.WriteLine("Username: " + username);

            // String Array
            string[] names = { "Alice", "Bob", "Charlie" };

            Console.WriteLine("\nNames:");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nFirst Name: " + names[0]);
            Console.WriteLine("Total Names: " + names.Length);

            // Integer Array
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("\nNumbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("\nMaximum: " + numbers.Max());
            Console.WriteLine("Minimum: " + numbers.Min());
            Console.WriteLine("Sum: " + numbers.Sum());

            // Multidimensional Array
            Console.WriteLine("\nMatrix:");

            int[,] matrix =
            {
                { 1, 2 },
                { 5, 6 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Method Call
            Console.WriteLine();
            mymethod("hello");

            // Object Creation
            Program myObj = new Program();

            myObj.name = "John";

            Console.WriteLine("\nObject Name: " + myObj.name);

            // Collections & LINQ.
            List<string> Names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            // list of objects
            List<students> students = new List<students>();
            students.Add(new student){
                name = "Alice",
                    age = 20
            });
            foreach(student student in students)
            {
                Console.WriteLine(student.name + " is " + student.age + " years old.");
            })
            practice p = new practice();
            p.variable();
            p.conditions();
            p.loops();
            p.whileloop();

            Console.ReadLine();
        }
    }
}