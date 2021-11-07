using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstFactorial = CalculatesFactorial(int.Parse(Console.ReadLine()));
            decimal secondFactorial = CalculatesFactorial(int.Parse(Console.ReadLine()));

            PrintsDivision(firstFactorial, secondFactorial);

        }

        static decimal CalculatesFactorial(int number)
        {
            decimal result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        static void PrintsDivision(decimal firstFactorial, decimal secondFactorial)
        {
            decimal result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");
        }
    }
}
