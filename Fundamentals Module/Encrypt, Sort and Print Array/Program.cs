using System;
using System.Linq;

namespace Encrypt_Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int[] outputToSort = new int[numInput];
            for (int i = 0; i < numInput; i++)
            {
                string input = Console.ReadLine();
                char[] arr = new char[input.Length];
                for (int l = 0; l < input.Length; l++)
                {
                    arr[l] = input[l];
                }
                int[] numArr = new int[arr.Length];
                for (int j = 0; j < arr.Length; j++)
                {
                    switch (arr[j])
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            numArr[j] = Convert.ToInt32(arr[j] * arr.Length);
                            break;
                        default:
                            numArr[j] = Convert.ToInt32(arr[j] / arr.Length);
                            break;
                    }
                }
                int sum = numArr.Sum();
                outputToSort[i] = sum;
            }
            Array.Sort(outputToSort);
            foreach (var elem in outputToSort)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
