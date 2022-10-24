using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hatsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] scarfsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            Stack<int> hats = new Stack<int>();
            foreach (var num in hatsArr)
            {
                hats.Push(num);
            }
            Queue<int> scarfs = new Queue<int>();
            foreach (var num in scarfsArr)
            {
                scarfs.Enqueue(num);
            }
            List<int> sets = new List<int>();
            while (Math.Min(scarfs.Count, hats.Count) > 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if (hat > scarf)
                {
                    sets.Add(hats.Pop() + scarfs.Dequeue());
                }
                else if (hat < scarf)
                {
                    hats.Pop();
                    if (hats.Count > 0 && hats.Peek() > scarf)
                    {
                        sets.Add(hats.Pop() + scarfs.Dequeue());
                    }
                }
                else
                {
                    scarfs.Dequeue();
                    hat++;
                    hats.Pop();
                    hats.Push(hat);
                }

            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");

            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
