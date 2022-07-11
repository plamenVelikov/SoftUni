using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > list.Count - 1)
                    {
                        endIndex = list.Count - 1;
                    }
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        list[startIndex] += list[startIndex + 1];
                        list.RemoveAt(startIndex + 1);
                    }
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int parts = int.Parse(command[2]);
                    var result = new List<string>();
                    string element = list[index];
                    int numElements = element.Length / parts;
                    list.RemoveAt(index);
                    for (int i = 0; i < parts; i++)
                    {
                        if (i != parts - 1)
                        {
                            result.Add(element.Substring(i * numElements, numElements));
                        }
                        else
                        {
                            result.Add(element.Substring(i * numElements));
                        }
                    }
                    list.InsertRange(index, result);
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(' ', list));
        }
    }
}
