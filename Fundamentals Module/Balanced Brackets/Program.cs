using System;

namespace Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter40 = 0;
            int counter41 = 0;
            int counterLimiter = 0;
            bool isBalanced = true;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    counter40++;
                    
                    
                }
                else if (input == ")")
                {
                    counter41++;
                    if (counter40 - counter41 != 0)
                    {
                        isBalanced = false;
                    }
                    
                }
            }
            if (counter40 == counter41 && isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
