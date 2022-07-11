using System;

namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(PowerUp(num, pow));
        }
        static double PowerUp(double num, int pow)
        {
            double result = 1d;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}