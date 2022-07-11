using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> raceTrack = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double timeLeft = 0;
            double timeRight = 0;
            int finishLine = raceTrack.Count / 2;
            bool didLeftHitZero = false;
            bool didRightHitZero = false;
            for (int i = 0; i < finishLine; i++)
            {
                if (raceTrack[i] != 0)
                {
                    timeLeft += raceTrack[i];
                }
                else if (raceTrack[i] == 0)
                {
                    timeLeft *= 0.8;
                    didLeftHitZero = true;
                }
            }

            for (int i = raceTrack.Count - 1; i > finishLine; i--)
            {
                if (raceTrack[i] != 0)
                {
                    timeRight += raceTrack[i];
                }
                else if (raceTrack[i] == 0)
                {
                    timeRight *= 0.8;
                    didRightHitZero = true;
                }
            }
            if (timeLeft < timeRight)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeft}");


            }
            else if (timeRight < timeLeft)
            {
                Console.WriteLine($"The winner is right with total time: {timeRight}");

            }
        }
    }
}
