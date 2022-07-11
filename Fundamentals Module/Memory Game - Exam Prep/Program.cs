using System;
using System.Collections.Generic;

namespace Memory_Game___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            List<string> seqList = new List<string>();
            List<string> tempList = new List<string>();
            seqList.AddRange(sequence);

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            while (command[0] != "end")
            {
                int index1 = int.Parse(command[0]);
                int index2 = int.Parse(command[1]);
                counter++;
                if (index1 >= 0 && index1 < seqList.Count && index2 >= 0 && index2 < seqList.Count && index1 != index2)
                {
                    if (seqList[index1] == seqList[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {seqList[index1]}!");
                        seqList.RemoveAt(Math.Max(index1, index2));
                        seqList.RemoveAt(Math.Min(index1, index2));
                        
                        if (seqList.Count == 0)
                        {
                            Console.WriteLine($"You have won in {counter} turns!");
                            return;
                        }
                    }
                    else if (seqList[index1] != seqList[index2])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    tempList.Add($"-{counter}a");
                    tempList.Add($"-{counter}a");
                    seqList.InsertRange(seqList.Count / 2, tempList);
                    tempList.Clear();
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(' ', seqList));
        }
    }
}
