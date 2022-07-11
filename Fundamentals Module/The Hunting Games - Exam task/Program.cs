using System;

namespace The_Hunting_Games___Exam_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numDaysAdventure = double.Parse(Console.ReadLine());
            double numPlayers = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());

            double waterPerDayPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerson = double.Parse(Console.ReadLine());
            int counterDays = 1;

            double waterResource = waterPerDayPerson * numPlayers * numDaysAdventure;
            double foodResource = foodPerDayPerson * numPlayers * numDaysAdventure;


            while (numDaysAdventure > 0)
            {
                double energyLostAtWork = double.Parse(Console.ReadLine());
                if (energyLostAtWork >= energy)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {foodResource:f2} food and {waterResource:f2} water.");
                    return;
                }
                else
                {
                    energy -= energyLostAtWork;
                }


                

                if (counterDays % 2 == 0)
                {
                    energy += energy * (double)0.05;
                    waterResource -= waterResource * (double)0.30;
                }
                if (counterDays % 3 == 0)
                {
                    energy += energy * (double)0.10;
                    foodResource -= foodResource / numPlayers;
                }
                counterDays++;
                numDaysAdventure--;
            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
        }
    }
}
