using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isRightLength = GetTheLengthPassword(password);
            bool isRightSymbols = GetTheSymbolsPassword(password);
            bool countDigits = CountDigits(password);

            if (isRightLength && isRightSymbols && countDigits)
            {
                Console.WriteLine("Password is valid");
            }
            if (!isRightLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isRightSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!countDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool GetTheLengthPassword(string password)
        {
            bool result = false;

            int passwordLength = password.Length;

            if (passwordLength >= 6 && passwordLength <= 10)
            {
                result = true;
            }

            return result;
        }
        static bool GetTheSymbolsPassword(string password)
        {
            bool result = password.All(Char.IsLetterOrDigit);

            return result;
        }
        static bool CountDigits(string password)
        {
            bool result = false;
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                bool currentSymbol = char.IsDigit(password[i]);
                

                if (currentSymbol)
                {
                    counter++;
                }
                if (counter >= 2)
                {
                    result = true;
                    break;
                }

            }

            return result;
        }
    }
}
