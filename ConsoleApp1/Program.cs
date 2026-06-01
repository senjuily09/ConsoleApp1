using System;
namespace ConsoleApp1
{
    class Program
    {
        static void mymethod(string fname)
        {
            Console.WriteLine(fname + "world");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string username = Console.ReadLine();
            Console.WriteLine(username);
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(names[0]);
            Console.WriteLine(names.Length);
            int[] numbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            // Multidimensional array
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            for (int i = 0; i < matrix.Length; i++) {
                Console.WriteLine(i);
            }
            mymethod("hello");
        }
    }
}