using System;
using System.Collections.Generic;

namespace Take___Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMsg = Console.ReadLine();
            List<int> numbersList = new List<int>();
            List<char> nonNumbersList = new List<char>();
            List<string> result = new List<string>();
            for (int i = 0; i < encryptedMsg.Length; i++)
            {
                if (int.TryParse(encryptedMsg[i].ToString(), out _))
                {
                    numbersList.Add(Convert.ToInt32(encryptedMsg[i].ToString()));
                }
                else
                {
                    nonNumbersList.Add(encryptedMsg[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }
            int toSkip = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0 ; j < takeList[i]; j++)
                {
                    if (j + toSkip > nonNumbersList.Count - 1)
                    {
                        Console.WriteLine(string.Join("", result));

                        return;
                    }
                    result.Add(nonNumbersList[j + toSkip].ToString());
                }
                toSkip += skipList[i] + takeList[i];
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
