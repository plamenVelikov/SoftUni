using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counterSeq = 0;
            int counterBiggestSeq = 0;
            int elemPos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counterSeq++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counterSeq > counterBiggestSeq)
                {
                    counterBiggestSeq = counterSeq;
                    elemPos = i;
                    counterSeq = 0;
                }
                else
                {
                    counterSeq = 0;
                }
            }
            for (int b = 0; b < counterBiggestSeq; b++)
            {
                Console.Write($"{arr[elemPos]} ");
            }
        }
    }
}
