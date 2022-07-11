using System;

namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int sumEven = GetSumOfEvenDigits(number);
            int sumOdd = GetSumOfOddDigits(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumOdd, sumEven));
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int digits = number;
            while (digits > 0)
            {
                int currNum = digits % 10;
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
                digits /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            int digits = number;
            while (digits > 0)
            {
                int currNum = digits % 10;
                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }
                digits /= 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int odd, int even)
        {
            return odd * even;
        }
    }
}
