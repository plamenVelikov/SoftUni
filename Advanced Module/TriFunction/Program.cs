using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<char[], int> accumulator = c =>
            {
                int sum = 0;
                foreach (var charac in c)
                {
                    sum += charac;
                }
                return sum;
            };

            Func<string, int, bool> checker = (s, n) =>
            {
                char[] charArr = s.ToCharArray();
                if (accumulator(charArr) >= n)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };

            foreach (var name in names)
            {
                if (checker(name, number))
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }
    }
}
