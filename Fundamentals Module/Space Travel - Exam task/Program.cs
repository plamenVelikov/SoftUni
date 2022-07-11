using System;

namespace Space_Travel___Exam_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("||");
            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                string[] command = input[i].Split(' ');

                switch (command[0])
                {
                    case "Travel":
                        if (int.Parse(command[1]) > fuel)
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"The spaceship travelled {int.Parse(command[1])} light-years.");
                            fuel -= int.Parse(command[1]);
                        }
                        break;
                    case "Enemy":
                        if (int.Parse(command[1]) <= ammo)
                        {
                            ammo -= int.Parse(command[1]);
                            Console.WriteLine($"An enemy with {int.Parse(command[1])} armour is defeated.");
                        }
                        else
                        {
                            if (fuel - int.Parse(command[1]) * 2 <= 0)
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"An enemy with {int.Parse(command[1])} armour is outmaneuvered.");
                                fuel -= int.Parse(command[1]) * 2;
                            }
                        }
                        break;
                    case "Repair":
                        ammo += int.Parse(command[1]) * 2;
                        fuel += int.Parse(command[1]);
                        Console.WriteLine($"Ammunitions added: {int.Parse(command[1]) * 2}.");
                        Console.WriteLine($"Fuel added: {int.Parse(command[1])}.");
                        break;
                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;
                        
                    default:
                        break;
                }
            }
        }
    }
}
