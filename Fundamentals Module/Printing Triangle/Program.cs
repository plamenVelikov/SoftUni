using System;

namespace Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintingLine(1, i);
            }
            for (int l = n - 1; l >= 0; l--)
            {
                PrintingLine(1, l);
            }
            
        }

        static void PrintingLine(int start, int n)
        {
            for (int i = start; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
