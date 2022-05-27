using System;

namespace Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal gbp = decimal.Parse(Console.ReadLine());
            decimal usd = gbp * 1.31M;
            Console.WriteLine($"{usd:f3}");
        }
    }
}
