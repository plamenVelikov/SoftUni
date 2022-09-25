using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPumps = int.Parse(Console.ReadLine());
            Queue<int[]> queMain = new Queue<int[]>();

            for (int i = 0; i < numPumps; i++)
            {
                queMain.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }
            
            //1 5      10 3         3 4

            int answer = numPumps;

            for (int i = 0; i < numPumps; i++)
            {
                Queue<int[]> que = new Queue<int[]>(queMain);
                for (int z = 0; z < i; z++)
                {
                    que.Enqueue(que.Dequeue());
                }

                int tank = 0;

                for (int j = 0; j <= numPumps; j++)
                {
                    int[] currStation = que.Dequeue();
                    if (tank + currStation[0] >= currStation[1])
                    {
                        tank += currStation[0] - currStation[1];
                        que.Enqueue(currStation);
                        if (j == numPumps)
                        {
                            if (i < answer)
                            {
                                answer = i;
                            }
                        }
                    }
                    else
                    {
                        que.Enqueue(currStation);
                        break;
                    }
                }

            }
            Console.WriteLine(answer);
        }
    }
}
