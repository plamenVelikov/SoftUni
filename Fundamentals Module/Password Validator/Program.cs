using System;
using System.Linq;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            PassErrorCheck(input);
        }

        static void PassErrorCheck(string password)
        {
            bool isPassValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isPassValid = false;
            }
            bool DoesPassContainOtherSymbols = false;
            foreach (var symbol in password)
            {
                if (symbol >= 48 && symbol <= 57 || symbol >= 97 && symbol <= 122)
                {
                    continue;
                }
                else
                {
                    DoesPassContainOtherSymbols = true;
                }
            }
            if (DoesPassContainOtherSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPassValid = false;
            }

            int digitNum = password.Count(digits => "1234567890".Contains(digits));
            if (digitNum < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isPassValid = false;
            }

            if (isPassValid)
            {
                Console.WriteLine("Password is valid");
            }
            
        }
    }
}
