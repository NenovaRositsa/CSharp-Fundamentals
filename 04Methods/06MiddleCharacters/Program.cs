using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintsTheMiddleCharacter(Console.ReadLine());
        }

        static void PrintsTheMiddleCharacter(string input)
        {
            int stringLength = input.Length;

            if (stringLength %2 != 0)
            {
                int result = stringLength / 2;
                Console.WriteLine(input[result]);
            }
            else
            {
                int result = stringLength / 2;
                Console.WriteLine($"{input[result - 1]}{input[result]}");
            }
        }
    }
}
