using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int numHoursDaily = int.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 1; i <= numDays; i++)
            {
                double dailySum = 0;
                for (int j = 1; j <= numHoursDaily; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            dailySum += 2.50;
                        }
                        else
                        {
                            dailySum += 1;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            dailySum += 1.25;
                        }
                        else
                        {
                            dailySum += 1;
                        }
                    }
                }
                totalSum += dailySum;
                Console.WriteLine($"Day: {i} - {dailySum:f2} leva");
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}