using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputOne = char.Parse(Console.ReadLine());
            char inputTwo = char.Parse(Console.ReadLine());

            PrintAllTheCharsBetweenTwoChars(inputOne, inputTwo);
        }

        static void PrintAllTheCharsBetweenTwoChars(char firstChar, char secondChar)
        {
            int startCharacter = Math.Min(firstChar, secondChar);
            int endCharacter = Math.Max(firstChar, secondChar);

            for (int i = ++startCharacter; i < endCharacter; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }
    }
}
