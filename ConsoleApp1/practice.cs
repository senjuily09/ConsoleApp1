using System;
namespace ConsoleApp1
{
    internal class practice
    {
        public void variable() {
            Console.WriteLine("Variables :");
            int myNum = 5;               // Integer (whole number)
        float myFloatNum = 5.99f;     // Floating point number
        string myString = "Hello";     // String
        char grade = 'A';              // Character
        bool isCSharpFun = true;       // Boolean
        long myLongNum = 15000000000L; // Long integer
        short myShortNum = 5000;       // Short integer
        Console.WriteLine($"Integer: {myNum} float: {myFloatNum} string: {myString} char: {grade} bool: {isCSharpFun} long: {myLongNum} short: {myShortNum}" );
      
}
        public void conditions()
        {
            Console.WriteLine("Conditions :");
            int time = 20;
            if (time > 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public void loops()
        {
            Console.WriteLine("Loops :");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void whileloop()
        {
            Console.WriteLine("While Loop :");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }


        }
}