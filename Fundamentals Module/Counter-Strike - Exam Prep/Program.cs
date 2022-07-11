using System;

namespace Counter_Strike___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battlesWonCount = 0;

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "End")
            {
                if (int.Parse(command[0]) <= energy)
                {
                    energy -= int.Parse(command[0]);
                    battlesWonCount++;
                    if (battlesWonCount % 3 == 0)
                    {
                        energy += battlesWonCount;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWonCount} won battles and {energy} energy");
                    return;
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine($"Won battles: {battlesWonCount}. Energy left: {energy}");
        }
    }
}
