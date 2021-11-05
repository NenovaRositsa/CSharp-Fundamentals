using System;
using System.Linq;

namespace _08MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            int number = int.Parse(Console.ReadLine());
            int length = numbersArr.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (numbersArr[i] + numbersArr[j] == number)
                    {
                        Console.WriteLine(numbersArr[i] + " " + numbersArr[j]);
                    }
                }
            }
        }
    }
}
