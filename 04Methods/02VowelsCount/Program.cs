using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowelsCount(input);
        }

        static void VowelsCount(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (currentSymbol == 'a' || currentSymbol == 'o' || currentSymbol == 'u' || currentSymbol == 'e' || currentSymbol == 'i' || currentSymbol == 'y')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
