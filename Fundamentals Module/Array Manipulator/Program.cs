using System;
using System.Linq;

namespace Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string commands = Console.ReadLine();
            string[] commandArr = commands.Split(' ');
            while (commands != "end")
            {
                switch (commandArr[0])
                {
                    case "exchange":
                        if (double.Parse(commandArr[1]) < 0 || double.Parse(commandArr[1]) >= numbers.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers = Exchange(numbers, int.Parse(commandArr[1]));
                        }
                        break;
                    case "max":
                        MaxIndex(numbers, commandArr[1]);
                        break;
                    case "min":
                        MinIndex(numbers, commandArr[1]);
                        break;
                    case "first":
                        if (double.Parse(commandArr[1]) > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            FirstCount(numbers, int.Parse(commandArr[1]), commandArr[2]);
                        }
                        break;
                    case "last":
                        if (double.Parse(commandArr[1]) > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            LastCount(numbers, int.Parse(commandArr[1]), commandArr[2]);
                        }
                        break;
                    default:
                        break;
                }
                commands = Console.ReadLine();
                commandArr = commands.Split(' ');
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        private static void LastCount(int[] numbers, int count, string evenOrOdd)
        {
            int arrCounter = 0;
            int[] resultArr = new int[numbers.Length];
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (evenOrOdd == "even")
                {
                    if (numbers[i] % 2 == 0)
                    {
                        resultArr[arrCounter] = numbers[i];
                        arrCounter++;
                        if (arrCounter == count)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if (numbers[i] % 2 != 0)
                    {
                        resultArr[arrCounter] = numbers[i];
                        arrCounter++;
                        if (arrCounter == count)
                        {
                            break;
                        }
                    }
                }
            }
            if (arrCounter == 0)
            {
                Console.WriteLine("[]");
                return;
            }
            int[] resultArrFinal = new int[arrCounter];
            for (int i = 0; i < arrCounter; i++)
            {
                resultArrFinal[i] = resultArr[i];
            }
            Array.Reverse(resultArrFinal);

            if (arrCounter == count)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", resultArrFinal)}]");
                    return;
                }
            }
            if (arrCounter < count)
            {
                Console.Write("[");
                for (int i = 0; i < arrCounter; i++)
                {
                    if (i == arrCounter - 1)
                    {
                        Console.Write($"{resultArr[i]}]");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write($"{resultArrFinal[i]}, ");
                    }
                }

            }
        }
        private static void FirstCount(int[] numbers, int count, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                int arrCounter = 0;
                int[] resultArr = new int[count];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        resultArr[arrCounter] = numbers[i];
                        arrCounter++;
                    }
                    if (arrCounter == count)
                    {
                        Console.WriteLine($"[{string.Join(", ", resultArr)}]");
                        return;
                    }
                }
                if (arrCounter == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
                if (arrCounter < count)
                {
                    Console.Write("[");
                    for (int i = 0; i < arrCounter; i++)
                    {
                        if (i == arrCounter - 1)
                        {
                            Console.Write($"{resultArr[i]}]");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write($"{resultArr[i]}, ");
                        }
                    }
                }
            }
            else if (evenOrOdd == "odd")
            {
                int arrCounter = 0;
                int[] resultArr = new int[count];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        resultArr[arrCounter] = numbers[i];
                        arrCounter++;
                    }
                    if (arrCounter == count)
                    {
                        Console.WriteLine($"[{string.Join(", ", resultArr)}]");
                        return;
                    }
                }
                if (arrCounter == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
                if (arrCounter < count)
                {
                    Console.Write("[");
                    for (int i = 0; i < arrCounter; i++)
                    {
                        if (i == arrCounter - 1)
                        {
                            Console.Write($"{resultArr[i]}]");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write($"{resultArr[i]}, ");
                        }
                    }
                }
            }

        }
        private static void MinIndex(int[] numbers, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                int lowestNUm = int.MaxValue;
                int indexPos = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] <= lowestNUm)
                        {
                            lowestNUm = numbers[i];
                            indexPos = i;
                        }
                    }
                }
                if (indexPos == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(indexPos);
                }
            }
            else if (evenOrOdd == "odd")
            {
                int lowestNum = int.MaxValue;
                int indexPos = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] <= lowestNum)
                        {
                            lowestNum = numbers[i];
                            indexPos = i;
                        }
                    }
                }
                if (indexPos == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(indexPos);
                }
            }
        }
        static void MaxIndex(int[] numbers, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                int biggestNum = int.MinValue;
                int indexPos = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] >= biggestNum)
                        {
                            biggestNum = numbers[i];
                            indexPos = i;
                        }
                    }
                }
                if (indexPos == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(indexPos);
                }
            }
            else if (evenOrOdd == "odd")
            {
                int biggestNum = int.MinValue;
                int indexPos = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] >= biggestNum)
                        {
                            biggestNum = numbers[i];
                            indexPos = i;
                        }
                    }
                }
                if (indexPos == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(indexPos);
                }
            }
        }
        static int[] Exchange(int[] numbers, int index)
        {
            int[] newArr = new int[numbers.Length];
            int[] firstArr, secondArr;

            firstArr = numbers.Take(index + 1).ToArray();
            secondArr = numbers.Skip(index + 1).ToArray();
            return newArr = secondArr.Concat(firstArr).ToArray();
        }
    }
}