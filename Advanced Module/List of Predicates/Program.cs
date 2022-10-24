using System;
using System.Linq;

namespace List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCeiling = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            dividers = dividers.Where(x => x != 1).ToArray();
            int[] arrNums = Enumerable.Range(1, numCeiling).ToArray();

            Predicate<int> isItDividable = num =>
            {
                foreach (var number in dividers)
                {
                    if (num % number != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            for (int i = 0; i < arrNums.Length; i++)
            {
                if (isItDividable(arrNums[i]))
                {
                    Console.Write($"{arrNums[i]} ");
                }
            }
        }
    }
}
