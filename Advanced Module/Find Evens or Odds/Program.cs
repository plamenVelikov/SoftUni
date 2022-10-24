using System;
using System.Linq;

namespace Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Predicate<int> filterEven = i => i % 2 == 0;
            Predicate<int> filterOdd = i => i % 2 != 0;
            Predicate<string> isItEvenNumbers = s => s == "even";

            for (int i = arr[0]; i <= arr[1]; i++)
            {
                if (isItEvenNumbers(command))
                {
                    if (filterEven(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
                else
                {
                    if (filterOdd(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
            }

        }
    }
}
