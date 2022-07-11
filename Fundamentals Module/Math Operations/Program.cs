using System;

namespace Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            
            Console.WriteLine(Result(firstNum, @operator, secondNum));
        }

        static double Result(double n1, char @operator, double n2)
        {
            double result = 0;
            switch (@operator)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
            }
            return result;
        }
    }
}
