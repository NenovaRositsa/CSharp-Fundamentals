using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintsMatrix(int.Parse(Console.ReadLine()));
        }

        static void PrintsMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();

            }
        }
    }
}
