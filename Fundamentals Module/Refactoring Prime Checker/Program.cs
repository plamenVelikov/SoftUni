﻿using System;

namespace Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                string isItPrime = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isItPrime = "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isItPrime);
            }
        }
    }
}
