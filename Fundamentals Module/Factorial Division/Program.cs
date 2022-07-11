using System;

namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{PrintResult(firstNum, secondNum):f2}");
        }

        private static double PrintResult(int firstNum, int secondNum)
        {
            double factorialFirstNum = firstNum;
            for (int i = firstNum - 1; i > 1; i--)
            {
                factorialFirstNum *= i;
            }

            double factorialSecondNum = secondNum;
            for (int j = secondNum - 1; j > 1; j--)
            {
                factorialSecondNum *= j;
            }

            return factorialFirstNum / factorialSecondNum;
        }
    }
}
