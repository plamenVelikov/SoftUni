using System;

namespace ConditionalStatementsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {


            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());

            int hArrival = int.Parse(Console.ReadLine());
            int mArrival = int.Parse(Console.ReadLine());

            int timeExam = hExam * 60 + mExam;
            int timeArrival = hArrival * 60 + mArrival;
            int timeDiff = timeArrival - timeExam;
            int hDiff = Math.Abs(timeDiff / 60);
            int mDiff = Math.Abs(timeDiff % 60);

            if (timeDiff < -30)
            {
                Console.WriteLine("Early");
            }
            else if (timeDiff <= 0)
            {
                Console.WriteLine("Late");
            }
            else
            {
                Console.WriteLine("On time");
            }

            if (hDiff > 0)
            {
                if (mDiff < 10)
                {
                    Console.Write($"{hDiff}:0{mDiff} hours ");

                }
                else
                {
                    Console.Write($"{hDiff}:{mDiff} hours ");
                }
            }
            else
            {
                Console.Write($"{mDiff} minutes ");
            }

            if (timeDiff < 0)
            {
                Console.WriteLine("before the start");
            }
            else
            {
                Console.WriteLine("after the start");
            }

        }
    }
}


