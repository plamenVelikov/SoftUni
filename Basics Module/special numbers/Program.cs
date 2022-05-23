using System;

namespace TestWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 1111; i <= 9999; i++)
            {
                int counter = 0;

                string str = i.ToString();
                

                for (int j = 0; j < str.Length; j++)
                {
                    var charArray = str.ToCharArray();
                    int x = int.Parse(charArray[j].ToString());
                    if (x == 0)
                    {
                        break;
                    }
                    else if (num % x == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 4)
                {
                    Console.Write($"{i} ");
                }
                
                
            }
        }
    }
}
