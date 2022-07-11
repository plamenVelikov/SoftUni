using System;
using System.Linq;

namespace Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                int sumLeft = 0;
                int sumRight = 0;
                for (int a = i - 1; a >= 0; a--)
                {
                    sumLeft += arr[a];
                }
                for (int b = i + 1; b < arr.Length; b++)
                {
                    sumRight += arr[b];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
