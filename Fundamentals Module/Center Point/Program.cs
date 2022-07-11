using System;

namespace Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CenterPointCalc(x1, y1, x2, y2);
        }

        static void CenterPointCalc(double x1, double y1, double x2, double y2)
        {
            double first = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double second = Math.Pow(x2, 2) + Math.Pow(y2, 2);


            if (first <= second)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
