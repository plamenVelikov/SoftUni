using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestKegModel = null;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestKegModel = model;
                }
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
