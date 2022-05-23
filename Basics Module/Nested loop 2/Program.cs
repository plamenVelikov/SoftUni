using System;

namespace nestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            bool spec = true;
            int a;
            int b = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                b = i;
                while (b != 0)
                {
                    a = b % 10;
                    if (a == 0)
                    {
                        spec = false;
                        break;

                    }
                    else if (N % a == 0) b = b / 10;
                    else
                    {
                        spec = false;
                        break;
                    }
                    spec = true;
                }
                if (spec == true) Console.Write(i + " ");
            }
        }
    }
}
