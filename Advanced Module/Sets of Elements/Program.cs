using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> nSet = new HashSet<int>(sizes[0]);
            HashSet<int> mSet = new HashSet<int>(sizes[1]);

            for (int i = 0; i < sizes[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nSet.Add(num);
            }

            for (int i = 0; i < sizes[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                mSet.Add(num);
            }

            nSet.IntersectWith(mSet);
            Console.WriteLine(String.Join(" ", nSet));
        }
    }
}
