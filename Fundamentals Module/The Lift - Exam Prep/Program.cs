using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Lift___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pplWaiting = int.Parse(Console.ReadLine());
            List<int> cabinChain = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < cabinChain.Count; i++)
            {
                if (cabinChain[i] < 4)
                {
                    for (int j = cabinChain[i]; j < 4; j++)
                    {
                        cabinChain[i]++;
                        pplWaiting--;
                        if (pplWaiting == 0)
                        {
                            if (cabinChain.Sum() == cabinChain.Count * 4)
                            {
                                Console.WriteLine(string.Join(' ', cabinChain));

                                return;
                            }
                            Console.WriteLine("The lift has empty spots!");
                            Console.WriteLine(string.Join(' ', cabinChain));

                            return;
                        }
                    }
                }

            }
            Console.WriteLine($"There isn't enough space! {pplWaiting} people in a queue!");
            Console.WriteLine(string.Join(' ', cabinChain));
        }
    }
}
