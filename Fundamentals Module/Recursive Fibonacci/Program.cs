using System;

namespace Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(input));
        }

        static int Fibonacci(int input)
        {

            if (input == 1 || input == 2)
            {
                return 1;
            }
            return Fibonacci(input - 2) + Fibonacci(input - 1);
        }
    }
}
