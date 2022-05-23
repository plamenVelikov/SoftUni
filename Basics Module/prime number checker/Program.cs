using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;


            while (true)
            {
                int num = 0;
                int factor = 0;
                
                string flow = Console.ReadLine();
                
                if (flow == "stop")
                {
                    Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
                    Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
                    return;
                }

                num = int.Parse(flow);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                num = int.Parse(flow);

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        factor++;
                    }
                }
                if (factor == 2)
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
            }
        }
    }
}