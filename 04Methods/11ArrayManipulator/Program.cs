using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string[] inputConditions = Console.ReadLine().Split(' ').ToArray();

            while (inputConditions[0] != "end")
            {
                string command = inputConditions[0];

                if (command == "exchange")
                {
                    ExchangedArrayByIndex(inputArr, inputConditions);
                }
                else if (command == "max")
                {
                    if (inputConditions[1] == "odd")
                    {
                        PrintsMaxOddByIndex(inputArr);
                    }
                    else if (inputConditions[1] == "even")
                    {
                        PrintsMaxEvenByIndex(inputArr);
                    }
                }
                else if (command == "min")
                {
                    if (inputConditions[1] == "odd")
                    {
                        PrintsMinOddByIndex(inputArr);
                    }
                    else if (inputConditions[1] == "even")
                    {
                        PrintsMinEvenByIndex(inputArr);
                    }
                }
                else if (command == "first")
                {


                    if (inputConditions[2] == "odd")
                    {
                        PrintsTheFirstOddElements(inputArr, inputConditions);
                    }
                    else if (inputConditions[2] == "even")
                    {
                        PrintsTheFirstEvenElements(inputArr, inputConditions);
                    }
                }
                else if (command == "last")
                {

                    if (inputConditions[2] == "odd")
                    {
                        PrintsTheLastOddElements(inputArr, inputConditions);
                    }
                    else if (inputConditions[2] == "even")
                    {
                        PrintsTheLastEvenElements(inputArr, inputConditions);
                    }
                }

                inputConditions = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", inputArr)}]");

        }

        static void ExchangedArrayByIndex(int[] inputArr, string[] inputConditions)
        {
            int index = int.Parse(inputConditions[1]);

            if (index >= inputArr.Length || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                for (int i = 0; i <= index; i++)
                {
                    int currentNum = inputArr[0];

                    for (int j = 0; j < inputArr.Length - 1; j++)
                    {
                        inputArr[j] = inputArr[j + 1];
                    }
                    inputArr[inputArr.Length - 1] = currentNum;
                }
            }

        }
        static void PrintsMaxOddByIndex(int[] inputArr)
        {
            int indexMaxOdd = 0;
            int maxOdd = 0;
            bool canItBefound = false;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 != 0)
                {
                    if (inputArr[i] >= maxOdd)
                    {
                        maxOdd = inputArr[i];
                        indexMaxOdd = i;
                        canItBefound = true;
                    }
                }
            }
            if (canItBefound)
            {
                Console.WriteLine(indexMaxOdd);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintsMaxEvenByIndex(int[] inputArr)
        {
            int maxEven = 0;
            int indexMaxEven = 0;
            bool canItBefound = false;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == 0)
                {
                    if (inputArr[i] >= maxEven)
                    {
                        maxEven = inputArr[i];
                        indexMaxEven = i;
                        canItBefound = true;
                    }
                }
            }

            if (canItBefound)
            {
                Console.WriteLine(indexMaxEven);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintsMinOddByIndex(int[] inputArr)
        {
            int indexMinOdd = 0;
            int minOdd = int.MaxValue;
            bool canItBefound = false;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 != 0)
                {
                    if (inputArr[i] <= minOdd)
                    {
                        minOdd = inputArr[i];
                        indexMinOdd = i;
                        canItBefound = true;
                    }
                }
            }
            if (canItBefound)
            {
                Console.WriteLine(indexMinOdd);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintsMinEvenByIndex(int[] inputArr)
        {
            int minEven = int.MaxValue;
            int indexMinEven = 0;
            bool canItBefound = false;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == 0)
                {
                    if (inputArr[i] <= minEven)
                    {
                        minEven = inputArr[i];
                        indexMinEven = i;
                        canItBefound = true;
                    }
                }
            }

            if (canItBefound)
            {
                Console.WriteLine(indexMinEven);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }

        static void PrintsTheFirstOddElements(int[] inputArr, string[] inputConditions)
        {
            int countNumbers = int.Parse(inputConditions[1]);

            if (countNumbers > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> result = new List<int>();

                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 != 0)
                    {
                        result.Add(inputArr[i]);

                        if (result.Count == countNumbers)
                        {
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                            break;
                        }
                    }


                }

                if (result.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else if (result.Count > 0 && result.Count < countNumbers)
                {
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }

            }
        }

        static void PrintsTheFirstEvenElements(int[] inputArr, string[] inputConditions)
        {
            int countNumbers = int.Parse(inputConditions[1]);

            if (countNumbers > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> result = new List<int>();

                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 == 0)
                    {
                        result.Add(inputArr[i]);

                        if (result.Count == countNumbers)
                        {
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                            break;
                        }
                    }

                }

                if (result.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else if (result.Count > 0 && result.Count < countNumbers)
                {
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }

            }
        }

        static void PrintsTheLastOddElements(int[] inputArr, string[] inputConditions)
        {
            int countNumbers = int.Parse(inputConditions[1]);

            if (countNumbers > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> result = new List<int>();

                for (int i = inputArr.Length - 1; i >= 0; i--)
                {
                    if (inputArr[i] % 2 != 0)
                    {
                        result.Add(inputArr[i]);

                        if (result.Count == countNumbers)
                        {
                            result.Reverse();
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                            break;
                        }
                    }
                }

                if (result.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else if (result.Count > 0 && result.Count < countNumbers)
                {
                    result.Reverse();
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
            }
        }

        static void PrintsTheLastEvenElements(int[] inputArr, string[] inputConditions)
        {
            int countNumbers = int.Parse(inputConditions[1]);

            if (countNumbers > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> result = new List<int>();

                for (int i = inputArr.Length - 1; i >= 0; i--)
                {
                    if (inputArr[i] % 2 == 0)
                    {
                        result.Add(inputArr[i]);

                        if (result.Count == countNumbers)
                        {
                            result.Reverse();
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                            break;
                        }
                    }
                }

                if (result.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else if (result.Count > 0 && result.Count < countNumbers)
                {
                    result.Reverse();
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
                
            }
        }

    }
}