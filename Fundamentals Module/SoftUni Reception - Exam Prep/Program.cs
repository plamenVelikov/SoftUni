using System;

namespace SoftUni_Reception___Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empl1 = int.Parse(Console.ReadLine());
            int empl2 = int.Parse(Console.ReadLine());
            int empl3 = int.Parse(Console.ReadLine());
            int studentsToBeAns = int.Parse(Console.ReadLine());
            int answeredStudents = 0;
            int studentsPerHour = empl1 + empl2 + empl3;
            int hours = 0;
            int breaks = 0;

            while (answeredStudents < studentsToBeAns)
            {
                hours++;
                answeredStudents += studentsPerHour;
                if (hours % 4 == 0)
                {
                    breaks++;
                    answeredStudents -= studentsPerHour;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
