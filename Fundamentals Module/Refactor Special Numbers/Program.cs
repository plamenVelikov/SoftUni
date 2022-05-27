using System;

namespace Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;

            bool isSpecialNum = false;
            for (int i = 1; i <= num; i++)
            {
                total = 0;
                int numCopy = i;
                while (numCopy > 0)
                {
                    total += numCopy % 10;
                    numCopy = numCopy / 10;
                }
                isSpecialNum = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNum);
            }
        }
    }
}
