using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintsTopNumbers(input);
        }

        static void PrintsTopNumbers(int input)
        {
            int masterNumbers = 0;

            for (int i = 1; i <= input; i++)
            {
                string currentNum = i.ToString();
                int sum = 0;

                for (int k= 0; k < currentNum.Length; k++)
                {
                    sum += currentNum[k];
                }

                if (sum %8 == 0)
                {
                    

                    for (int j = 0; j < currentNum.Length; j++)
                    {
                        if (currentNum[j] %2 != 0)
                        {
                            masterNumbers = i;
                            Console.WriteLine(masterNumbers);
                           
                            break;
                            
                        }
                    }
                }
            }

            
        }
    }
}
