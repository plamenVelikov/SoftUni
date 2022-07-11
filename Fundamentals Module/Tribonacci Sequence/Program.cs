using System;

namespace Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Tribonacci(n);
        }

        static void Tribonacci(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    arr[i] = 1;
                }
                else if (i == 2)
                {
                    arr[i] = 2;
                }
                else
                {
                    arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
                }
            }
            Console.WriteLine(string.Join(' ', arr));
        }
    }
}