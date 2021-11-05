using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int leftSum = numbersArr[0];
            int rightSum = numbersArr.Sum() - leftSum;

            if (numbersArr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 1; i < numbersArr.Length; i++)
            {

                int currentNumber = numbersArr[i];

                rightSum -= currentNumber;

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    leftSum += currentNumber;
                }


            }

            Console.WriteLine("no");
        }
    }
}
