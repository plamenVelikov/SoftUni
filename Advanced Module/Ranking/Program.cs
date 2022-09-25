using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> examLog = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> studentsScores = new Dictionary<string, Dictionary<string, int>>();

            string[] examInput = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            while (examInput[0] != "end of contests")
            {
                if (!examLog.ContainsKey(examInput[0]))
                {
                    examLog.Add(examInput[0], examInput[1]);
                }

                examInput = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }

            //"{contest}=>{password}=>{username}=>{points}"

            string[] studentInput = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            while (studentInput[0] != "end of submissions")
            {
                if (examLog.ContainsKey(studentInput[0]) && examLog[studentInput[0]] == studentInput[1])
                {
                    if (!studentsScores.ContainsKey(studentInput[2]))
                    {
                        studentsScores.Add(studentInput[2], new Dictionary<string, int>());
                        studentsScores[studentInput[2]].Add(studentInput[0], int.Parse(studentInput[3]));
                    }
                    else
                    {
                        if (!studentsScores[studentInput[2]].ContainsKey(studentInput[0]))
                        {
                            studentsScores[studentInput[2]].Add(studentInput[0], int.Parse(studentInput[3]));
                        }
                        else
                        {
                            if (studentsScores[studentInput[2]][studentInput[0]] < int.Parse(studentInput[3]))
                            {
                                studentsScores[studentInput[2]][studentInput[0]] = int.Parse(studentInput[3]);
                            }

                        }
                    }
                }
                studentInput = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in studentsScores.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Values.Sum()} points.");
                break;
            }
            Console.WriteLine($"Ranking:");
            foreach (var student in studentsScores.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }


        }
    }
}
