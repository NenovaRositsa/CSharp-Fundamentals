using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = Subtract(Sum(firstNum, secondNum), thirdNum);
            Console.WriteLine(result);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }
    }
}
