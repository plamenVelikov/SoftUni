using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalYield = 0;
            int counterDays = 0;

            while (startingYield >= 100)
            {
                totalYield += startingYield - 26;
                counterDays++;
                startingYield -= 10;
                
            }
            if (totalYield - 26 >= 0)
            {
                totalYield -= 26;
            }
            else
            {
                totalYield = 0;
            }

            Console.WriteLine(counterDays);
            Console.WriteLine(totalYield);
        }
    }
}
