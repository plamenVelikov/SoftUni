using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Loot_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstBoxArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondBoxArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> firstBox = new Queue<int>();
            Stack<int> secondBox = new Stack<int>();

            foreach (var item in firstBoxArr)
            {
                firstBox.Enqueue(item);
            }
            foreach (var item in secondBoxArr)
            {
                secondBox.Push(item);
            }
            List<int> loot = new List<int>();

            while (Math.Min(firstBox.Count, secondBox.Count) != 0)
            {
                if ((firstBox.Peek() + secondBox.Peek()) % 2 == 0)
                {
                    int sum = firstBox.Dequeue() + secondBox.Pop();
                    loot.Add(sum);
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (loot.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {loot.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {loot.Sum()}");
            }


        }
    }
}
