using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songsList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> que = new Queue<string>(songsList);

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "Play":
                        que.Dequeue();
                        break;
                    case "Add":
                        string songName = string.Join(' ', commands).Substring(3).TrimStart();

                        if (!que.Contains(songName))
                        {
                            que.Enqueue(songName);
                        }
                        else
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", que));
                        break;
                    default:
                        break;
                }
                if (que.Count() == 0)
                {
                    Console.WriteLine("No more songs!");
                    return;
                }
            }
        }
    }
}
