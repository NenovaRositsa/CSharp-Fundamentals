using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentDigit = int.Parse(input[i].ToString());
                int currentFactorial = 1;

                for (int j = 1; j <= currentDigit; j++)
                {
                    currentFactorial *= j;
                }

                sum += currentFactorial;
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
