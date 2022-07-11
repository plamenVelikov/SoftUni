using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            char[] charArr = Console.ReadLine().ToCharArray();
            List<char> charList = new List<char>();
            charList.AddRange(charArr);
            List<char> resultList = new List<char>();
            for (int i = 0; i < listNumbers.Count; i++)
            {
                int sum = 0;
                int num = listNumbers[i];
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (sum > charList.Count - 1)
                {
                    sum = sum % charList.Count;
                }
                if (sum <= charList.Count - 1 && sum >= 0)
                {
                    resultList.Add(charList[sum]);
                    charList.RemoveAt(sum);
                }

            }
            foreach (var character in resultList)
            {
                Console.Write(character);
            }
        }
    }
}
