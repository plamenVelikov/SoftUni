﻿using System;

namespace Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{nameFirst}{delimiter}{nameSecond}");
        }
    }
}
