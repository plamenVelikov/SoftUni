using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studsByLangScore = new Dictionary<string, int>();
            Dictionary<string, int> langsBySubs = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
            //"{username}-{language}-{points}" 
            while (input[0] != "exam finished")
            {
                if (input[1] == "banned")
                {
                    studsByLangScore.Remove(input[0]);

                }
                else
                {
                    if (!langsBySubs.ContainsKey(input[1]))
                    {
                        langsBySubs.Add(input[1], 1);
                    }
                    else
                    {
                        langsBySubs[input[1]]++;
                    }
                    if (!studsByLangScore.ContainsKey(input[0]))
                    {
                        studsByLangScore.Add(input[0], int.Parse(input[2]));
                    }
                    else
                    {
                        if (studsByLangScore[input[0]] < int.Parse(input[2]))
                        {
                            studsByLangScore[input[0]] = int.Parse(input[2]);

                        }
                    }
                }


                input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("Results:");

            foreach (var item in studsByLangScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }


            Console.WriteLine("Submissions:");
            foreach (var item in langsBySubs.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
