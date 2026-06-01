using System;
using System.Linq;

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
            Console.ReadLine();
        }
    }
}