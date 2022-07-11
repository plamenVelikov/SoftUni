using System;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int fieldSize = int.Parse(Console.ReadLine());

            int[] ladyBugsPos = new int[fieldSize]; 

            string[] occupiedIndexes = Console.ReadLine().Split(); 

            for (int i = 0; i < occupiedIndexes.Length; i++)
            {
                int currentIndex = int.Parse(occupiedIndexes[i]);
                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    ladyBugsPos[currentIndex] = 1; 
                }
            }

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                bool isFirst = true;
                int currentIndex = int.Parse(input[0]);
                while (currentIndex >= 0 && currentIndex < fieldSize && ladyBugsPos[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladyBugsPos[currentIndex] = 0;
                        isFirst = false;
                    }

                    string direction = input[1];
                    int flightLenght = int.Parse(input[2]);
                    if (direction == "left")
                    {
                        currentIndex -= flightLenght;
                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladyBugsPos[currentIndex] == 0)
                            {
                                ladyBugsPos[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLenght;
                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladyBugsPos[currentIndex] == 0)
                            {
                                ladyBugsPos[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", ladyBugsPos));
        }
    }
}