﻿using System;
using System.Linq;

namespace Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int tempElem = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = tempElem;
            }
            Console.WriteLine(String.Join(' ', arr));
        }
    }
}
