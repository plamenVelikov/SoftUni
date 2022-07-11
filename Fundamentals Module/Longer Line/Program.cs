using System;

namespace Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());


            DistanceBetween(x1, y1, x2, y2, a1, b1, a2, b2);


        }

        static void DistanceBetween(double x1, double y1, double x2, double y2, double a1, double b1, double a2, double b2)
        {
            double distanceFirstLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double distanceSecondLine = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            if (distanceFirstLine > distanceSecondLine)
            {
                Console.WriteLine(CenterPointCalcFirst(x1, y1, x2, y2));
            }
            else
            {
                Console.WriteLine(CenterPointCalcFirst(a1, b1, a2, b2));
            }
        }

        static string CenterPointCalcFirst(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double second = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));


            if (first <= second)
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                return $"({x2}, {y2})({x1}, {y1})";
            }
        }
    }
}
