using System;
namespace ConsoleApp1
{
    class Program
    {
        string name = "";
        static void mymethod(string fname)
        {
            Console.WriteLine(fname + "world");
        }
        
        // class 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter USer name : ");
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
            int[,] matrix = { { 1, 2 }, { 5, 6 } };

            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            mymethod("hello");
            // class object
            Program myObj = new Program();
            Console.WriteLine(myObj.name);

        }
    }
}