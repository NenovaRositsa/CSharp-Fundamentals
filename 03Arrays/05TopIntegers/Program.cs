using System;
using System.Linq;

namespace _05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isTopInteger = false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                    else
                    {
                        isTopInteger = true;
                    }


                }

                if (isTopInteger)
                {
                    Console.Write(input[i] + " ");
                }
            }

            Console.WriteLine(input[input.Length - 1]);
        }
    }
}
