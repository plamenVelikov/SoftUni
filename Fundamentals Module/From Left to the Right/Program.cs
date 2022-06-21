using System;
using System.Linq;


namespace From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long sum = 0;
                if (arr[0] > arr[1])
                {
                    long numTemp = Math.Abs(arr[0]);
                    while (numTemp > 0)
                    {
                        long adition = numTemp % 10;
                        sum += adition;
                        numTemp /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else if (arr[0] <= arr[1])
                {
                    long numTemp = Math.Abs(arr[1]);
                    while (numTemp > 0)
                    {
                        long adition = numTemp % 10;
                        sum += adition;
                        numTemp /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
            }
        }
    }
}
