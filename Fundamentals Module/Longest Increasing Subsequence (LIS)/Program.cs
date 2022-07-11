using System;
using System.Linq;

namespace Longest_Increasing_Subsequence__LIS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] solutions = new int[input.Length];
            int[] previous = new int[input.Length];

            int maxSolution = 0;
            int maxSolutionIndex = 0;
            for (int curr = 0; curr < input.Length; curr++)
            {
                int solution = 1;
                int prevIndex = -1;
                int currentNumber = input[curr];
                for (int solIndex = 0; solIndex < curr; solIndex++)
                {
                    int prevNumber = input[solIndex];
                    int prevSolution = solutions[solIndex];
                    if (currentNumber > prevNumber && solution <= prevSolution)
                    {
                        solution = prevSolution + 1;
                        prevIndex = solIndex;
                    }
                }
                solutions[curr] = solution;
                previous[curr] = prevIndex;
                if (solution > maxSolution)
                {
                    maxSolution = solution;
                    maxSolutionIndex = curr;
                }

            }
            int index = maxSolutionIndex;
            int[] answer = new int[maxSolution];
            int counter = 0;
            while (index != -1)
            {
                int currentNumber = input[index];
                answer[counter] = currentNumber;
                index = previous[index];
                counter++;
            }
            Array.Reverse(answer);
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
