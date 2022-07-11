using System;
using System.Linq;

namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string output = "";
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        break;
                    }
                    else if (j == arr.Length - 1)
                    {
                        output += $"{arr[i]} ";
                    }
                }
            }
            Console.WriteLine($"{output}{arr[arr.Length - 1]}");
        }
    }
}
