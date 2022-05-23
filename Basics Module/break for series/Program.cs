using System;

namespace untitled
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double episodeDuration = int.Parse(Console.ReadLine());
            double breakDuration = int.Parse(Console.ReadLine());

            double lunchTime = breakDuration * 1 / 8;

            double relaxTime = breakDuration * 1 / 4;
            double breakLeftForSeries = breakDuration - lunchTime - relaxTime;



            if (breakLeftForSeries >= episodeDuration)
            {
                double timeLeft = breakLeftForSeries - episodeDuration;
                timeLeft = Math.Ceiling(timeLeft);
                Console.WriteLine($"You have enough time to watch {name} and left with {timeLeft} minutes free time.");
            }
            else if (episodeDuration > breakLeftForSeries)
            {
                double timeNeeded = episodeDuration - breakLeftForSeries;
                timeNeeded = Math.Ceiling(timeNeeded);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {timeNeeded} more minutes.");
            }



        }
    }
}