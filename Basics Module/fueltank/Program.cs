﻿using System;

namespace untitled
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());


            switch (fuelType)
            {
                case "Diesel":
                    if (liters >= 25)
                    {
                        Console.WriteLine($"You have enough diesel.");
                    }
                    else
                    {
                        Console.WriteLine($"Fill your tank with diesel!");
                    }
                    break;
                case "Gasoline":
                    if (liters >= 25)
                    {
                        Console.WriteLine($"You have enough gasoline.");
                    }
                    else
                    {
                        Console.WriteLine($"Fill your tank with gasoline!");
                    }
                    break;
                case "Gas":
                    if (liters >= 25)
                    {
                        Console.WriteLine($"You have enough gas.");
                    }
                    else
                    {
                        Console.WriteLine($"Fill your tank with gas!");
                    }
                    break;


                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }



        }
    }

}
