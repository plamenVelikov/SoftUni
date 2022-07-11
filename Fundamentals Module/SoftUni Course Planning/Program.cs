using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string[] command = Console.ReadLine().Split(':').ToArray();

            while (command[0] != "course start")
            {
                switch (command[0])
                {
                    case "Add":
                        if (!lessons.Contains(command[1]))
                        {
                            lessons.Add(command[1]);
                        }
                        break;
                    case "Insert":
                        if (!lessons.Contains(command[1]))
                        {
                            lessons.Insert(int.Parse(command[2]), command[1]);
                        }
                        break;
                    case "Remove":
                        if (lessons.Contains(command[1]))
                        {
                            lessons.Remove(command[1]);
                            if (lessons.Contains($"{command[1]}-Exercise"))
                            {
                                lessons.Remove($"{command[1]}-Exercise");
                            }
                        }
                        break;
                    case "Swap":
                        if (lessons.Contains(command[1]) && lessons.Contains(command[2]))
                        {
                            int index1 = lessons.FindIndex(x => x == command[1]);
                            List<string> tempArr1 = new List<string>();
                            int index2 = lessons.FindIndex(x => x == command[2]);
                            List<string> tempArr2 = new List<string>();

                            if (lessons.Contains($"{command[1]}-Exercise"))
                            {
                                tempArr1.Add(lessons[index1]);
                                tempArr1.Add(lessons[index1 + 1]);
                            }
                            else
                            {
                                tempArr1.Add(lessons[index1]);
                            }

                            if (lessons.Contains($"{command[2]}-Exercise"))
                            {
                                tempArr2.Add(lessons[index2]);
                                tempArr2.Add(lessons[index2 + 1]);
                            }
                            else
                            {
                                tempArr2.Add(lessons[index2]);
                            }

                            if (tempArr2.Count > tempArr1.Count)
                            {
                                lessons.RemoveAt(index1);
                                lessons.InsertRange(index1, tempArr2);
                                lessons.RemoveRange(index2 + 1, tempArr2.Count);
                                lessons.InsertRange(index2 + 1, tempArr1);
                            }
                            else if (tempArr1.Count > tempArr2.Count)
                            {
                                lessons.RemoveRange(index1, tempArr1.Count);
                                lessons.InsertRange(index1, tempArr2);
                                lessons.RemoveRange(index2 - 1, tempArr1.Count);
                                lessons.InsertRange(index2 - 1, tempArr1);
                            }
                            else
                            {
                                lessons.RemoveRange(index1, tempArr1.Count);
                                lessons.InsertRange(index1, tempArr2);
                                lessons.RemoveRange(index2, tempArr2.Count);
                                lessons.InsertRange(index2, tempArr1);
                            }
                        }
                        break;
                    case "Exercise":
                        if (lessons.Contains(command[1]) && !lessons.Contains($"{command[1]}-Exercise"))
                        {
                            int index = lessons.FindIndex(x => x == command[1]);
                            lessons.Insert(index + 1, $"{command[1]}-Exercise");

                        }
                        else if (!lessons.Contains(command[1]))
                        {
                            lessons.Add(command[1]);
                            lessons.Add($"{command[1]}-Exercise");
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(':').ToArray();
            }
            for (int i = 1; i <= lessons.Count; i++)
            {
                Console.WriteLine($"{i}.{lessons[i - 1]}");
            }
        }
    }
}
