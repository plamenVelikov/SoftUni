using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            •	2.00 – 2.99 - "Fail"
            //•	3.00 – 3.49 - "Poor"
            //•	3.50 – 4.49 - "Good"
            //•	4.50 – 5.49 - "Very good"
            //•	5.50 – 6.00 - "Excellent"
            double n = double.Parse(Console.ReadLine());
            Grades(n);
        }

        static void Grades(double n)
        {
            if (n >= 2.00 && n <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (n >= 3.00 && n <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (n >= 3.50 && n <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (n >= 4.50 && n <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (n >= 5.00 && n <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
