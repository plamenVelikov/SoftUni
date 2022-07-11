using System;

namespace Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            PrintTopNumbers(end);
        }

        static void PrintTopNumbers(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                bool isItDivisible = false;
                bool doesItContainOddNum = false;
                int sumDigits = 0;
                int temp = i;
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    int current = temp % 10;
                    if (current % 2 != 0)
                    {
                        doesItContainOddNum = true;
                    }
                    sumDigits += current;
                    temp /= 10;
                }
                if (sumDigits % 8 == 0)
                {
                    isItDivisible = true;
                }
                if (isItDivisible && doesItContainOddNum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
