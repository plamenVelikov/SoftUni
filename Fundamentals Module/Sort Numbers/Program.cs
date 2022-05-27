using System;

namespace Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];
            for (int i = 0; i < 3; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(x);
            Array.Reverse(x);
            foreach (int value in x)
            {
                Console.WriteLine(value);
            }
        }
    }
}
