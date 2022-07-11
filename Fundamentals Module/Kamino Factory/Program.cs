using System;
using System.Linq;

namespace Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] theBestSequence = new int[lenght];
            int[] currentSequence = new int[lenght];

            int sample = 0;
            int currentTheBestCounter = 0;
            int sum = 0;
            int bestIndex = 0;
            int bestSum = 0;
            int bestSequence = 0;
            int theBestSample = 0;

            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                int counterSequence = 0;
                int currentIndex = -1;
                bool isTheBestSequence = false;
                currentSequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sample++;
                currentTheBestCounter = 0;
                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    int firstNumber = currentSequence[i];
                    int secondNumber = currentSequence[i + 1];
                    if (firstNumber == 1 && secondNumber == 1)
                    {
                        counterSequence++;
                        if (counterSequence >= currentTheBestCounter)
                        {
                            currentIndex = i - counterSequence + 1;
                            currentTheBestCounter = counterSequence;
                            counterSequence = 0;
                        }
                    }
                }
                sum = currentSequence.Sum();
                if (currentTheBestCounter > bestSequence)
                {
                    isTheBestSequence = true;
                }
                else if (currentTheBestCounter == bestSequence)
                {
                    if (currentIndex < bestIndex)
                    {
                        isTheBestSequence = true;
                    }
                    else if (currentTheBestCounter == bestSequence && currentIndex == bestIndex)
                    {
                        if (sum > bestSum)
                        {
                            isTheBestSequence = true;
                        }
                    }
                }
                if (isTheBestSequence == true)
                {
                    bestSequence = currentTheBestCounter;
                    bestSum = sum;
                    bestIndex = currentIndex;
                    theBestSample = sample;
                    theBestSequence = currentSequence;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {theBestSample} with sum: {bestSum}.");
            foreach (var elem in theBestSequence)
            {
                Console.Write($"{elem} ");
            }
        }
    }
}