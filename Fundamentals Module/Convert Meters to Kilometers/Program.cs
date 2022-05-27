using System;

namespace Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float meters = int.Parse(Console.ReadLine());
            float km = meters / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
