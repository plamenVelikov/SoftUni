using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Angry_Cat___Exam_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int indexCat = int.Parse(Console.ReadLine());
            string typeToDestroy = Console.ReadLine();
            List<int> sequenceLeft = new List<int>();
            List<int> sequenceRight = new List<int>();
            sequenceRight.AddRange(sequence);
            sequenceLeft.AddRange(sequence);


            sequenceLeft.RemoveRange(indexCat, sequenceLeft.Count - indexCat);
            sequenceRight.RemoveRange(0, indexCat + 1);
            if (typeToDestroy == "cheap")
            {
                sequenceLeft.RemoveAll(x => x >= sequence[indexCat]);
                sequenceRight.RemoveAll(x => x >= sequence[indexCat]);
            }
            else if (typeToDestroy == "expensive")
            {
                sequenceLeft.RemoveAll(x => x < sequence[indexCat]);
                sequenceRight.RemoveAll(x => x < sequence[indexCat]);
            }

            if (sequenceLeft.Sum() > sequenceRight.Sum())
            {
                Console.WriteLine($"Left - {sequenceLeft.Sum()}");
            }
            else if (sequenceLeft.Sum() == sequenceRight.Sum())
            {
                Console.WriteLine($"Left - {sequenceLeft.Sum()}");
            }
            else
            {
                Console.WriteLine($"Right - {sequenceRight.Sum()}");
            }


            //for (int i = 0; i < indexCat; i++)
            //{
            //    if (typeToDestroy == "cheap")
            //    {
            //        if (sequence[i] < sequence[indexCat])
            //        {
            //            left.Add(sequence[i]);
            //        }
            //    }
            //    else if (typeToDestroy == "expensive")
            //    {
            //        if (sequence[i] >= sequence[indexCat])
            //        {
            //            left.Add(sequence[i]);
            //        }
            //    }
            //}

            //for (int i = indexCat + 1; i < sequence.Count; i++)
            //{
            //    if (typeToDestroy == "cheap")
            //    {
            //        if (sequence[i] < sequence[indexCat])
            //        {
            //            right.Add(sequence[i]);
            //        }
            //    }
            //    else if (typeToDestroy == "expensive")
            //    {
            //        if (sequence[i] >= sequence[indexCat])
            //        {
            //            right.Add(sequence[i]);
            //        }
            //    }
            //}

            //if (left.Sum() > right.Sum())
            //{
            //    Console.WriteLine($"Left - {left.Sum()}");
            //}
            //else if (left.Sum() == right.Sum())
            //{
            //    Console.WriteLine($"Left - {left.Sum()}");
            //}
            //else
            //{
            //    Console.WriteLine($"Right - {right.Sum()}");
            //}
        }
    }
}
