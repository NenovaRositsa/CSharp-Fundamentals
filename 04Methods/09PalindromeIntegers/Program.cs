using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintsPalindromeIntegers();
            
        }

        static void PrintsPalindromeIntegers()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] reverse = new string[input.Length];
                bool isPolindrome = false;

                for (int i = 0; i < input.Length; i++)
                {
                    reverse[i] = input[input.Length - 1 - i].ToString();
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (reverse[i].ToString() == input[i].ToString())
                    {
                        isPolindrome = true;
                    }
                    else
                    {
                        isPolindrome = false;
                        break;
                    }
                }
                
                if (isPolindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }


                input = Console.ReadLine();
            }
            return;

        }
    }
}