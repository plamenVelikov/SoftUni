using System;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            · The amount of money John has – floating - point number in the range[0.00…1000.00].

            //· The count of students – integer in the range[0…100].

            //· The price of lightsabers for a single saber – floating - point number in the range[0.00…100.00].

            //· The price of robes for a single robe – floating - point number in the range[0.00…100.00].

            //· The price of belts for a single belt – floating - point number in the range[0.00…100.00].

            float budget = float.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            float priceLightSab = float.Parse(Console.ReadLine());
            float priceRobe = float.Parse(Console.ReadLine());
            float priceBelt = float.Parse(Console.ReadLine());

            float totalSum = (float)(priceLightSab * Math.Ceiling(studentCount * 1.10) + priceRobe * studentCount + priceBelt * (studentCount - (studentCount / 6)));

            if (budget >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                float moneyNeeded = totalSum - budget;
                Console.WriteLine($" John will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
