using System;

namespace Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            SignChecker(a, b, c);
        }
        static void SignChecker(int a, int b, int c)
        {
            bool isThereZero = false;
            int negativeCount = 0;

            int[] arr = { a, b, c };

            for (int i = 0; i < 3; i++)
            {

                if (arr[i] < 0)
                {
                    negativeCount++;
                }
                if (arr[i] == 0)
                {
                    isThereZero = true;
                }
            }
            if (isThereZero)
            {
                Console.WriteLine("zero");
            }
            else if (negativeCount % 2 != 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
