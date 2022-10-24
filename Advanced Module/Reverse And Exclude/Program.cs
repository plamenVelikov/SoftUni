using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int divider = int.Parse(Console.ReadLine());
            Predicate<int> isItDividable = num => num % divider == 0;
            Func<int[], List<int>> ops = numbers =>
            {
                List<int> product = new List<int>();

                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (!isItDividable(numbers[i]))
                    {
                        product.Add(numbers[i]);
                    }
                }
                return product;
            };

            Console.WriteLine(String.Join(" ", ops(arr)));
        }
    }
}
