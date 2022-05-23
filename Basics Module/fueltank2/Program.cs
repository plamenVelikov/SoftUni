using System;

namespace untitled
{
    class Program
    {
        static void Main(string[] args)
        {

            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            double priceReducGasoline = 0.18;
            double priceReducDiesel = 0.12;
            double priceReducGas = 0.08;

            double totalCost = 0.0;

            if (clubCard == "Yes")
            {
                gasoline -= priceReducGasoline;
                diesel -= priceReducDiesel;
                gas -= priceReducGas;
            }

            switch (fuelType)
            {
                case "Gasoline":
                    if (liters >= 20 && liters <= 25)
                    {
                        totalCost = (liters * gasoline) * 0.92;
                    }
                    else if (liters > 25)
                    {
                        totalCost = (liters * gasoline) * 0.90;
                    }
                    else
                    {
                        totalCost = liters * gasoline;
                    }

                    break;
                case "Diesel":
                    if (liters >= 20 && liters <= 25)
                    {
                        totalCost = (liters * diesel) * 0.92;
                    }
                    else if (liters > 25)
                    {
                        totalCost = (liters * diesel) * 0.90;
                    }
                    else
                    {
                        totalCost = liters * diesel;
                    }

                    break;
                case "Gas":
                    if (liters >= 20 && liters <= 25)
                    {
                        totalCost = (liters * gas) * 0.92;
                    }
                    else if (liters > 25)
                    {
                        totalCost = (liters * gas) * 0.90;
                    }
                    else
                    {
                        totalCost = liters * gas;
                    }

                    break;

                default:
                    break;
            }
            Console.WriteLine($"{totalCost:f2} lv.");



        }
    }
}
