using System;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());

            int[] arr = { 0, 1, 0 };
            int[] arrMem = arr;

            Console.WriteLine("1");
            for (int i = 0; i < numLines - 1; i++)
            {
                int[] arrNext = new int[arrMem.Length + 2];
                for (int j = 0; j < arrMem.Length; j++)
                {
                    if (j == 0)
                    {
                        arrNext[0] = 0;
                    }
                    else
                    {
                        arrNext[j] = arrMem[j - 1] + arrMem[j];
                    }
                }
                arrMem = arrNext;

                for (int z = 0; z < arrNext.Length; z++)
                {
                    if (arrNext[z] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write($"{arrNext[z]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
