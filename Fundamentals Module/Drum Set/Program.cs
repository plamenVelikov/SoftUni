using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            List<int> drumSetOrig = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> drumSetToUse = drumSetOrig.ToList();

            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                for (int i = 0; i < drumSetToUse.Count; i++)
                {
                    drumSetToUse[i] -= int.Parse(command);
                    if (drumSetToUse[i] <= 0)
                    {
                        if (drumSetOrig[i] * 3 <= budget)
                        {
                            budget -= drumSetOrig[i] * 3;
                            drumSetToUse[i] = drumSetOrig[i];
                        }
                        else
                        {
                            drumSetToUse.RemoveAt(i);
                            drumSetOrig.RemoveAt(i);
                            i--;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', drumSetToUse));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}
