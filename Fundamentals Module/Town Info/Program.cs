using System;

namespace Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            int sqkm = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {sqkm} square km.");
        }
    }
}
