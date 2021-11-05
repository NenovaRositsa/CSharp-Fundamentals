using System;
using System.Linq;

namespace _02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            string result = string.Empty;

            bool smallerArray = false;


            if (firstArray.Length < secondArray.Length)
            {
                smallerArray = true;
            }

            if (smallerArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (secondArray.Contains(firstArray[i]))
                    {
                        result += firstArray[i] + " ";
                    }
                }
            }
            else
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray.Contains(secondArray[j]))
                    {
                        result += secondArray[j] + " ";
                    }
                }
            }

            string[] resultArray = result.Split(' ').ToArray();

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
