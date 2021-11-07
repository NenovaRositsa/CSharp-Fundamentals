using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int thirdNum = int.Parse(Console.ReadLine());

            GetTheSmallestNum(firstNum, secondNum, thirdNum);
        }

        static void GetTheSmallestNum(int a, int b, int c)
        {
            int theSmallestNum = 0;

            if (a < b && a < c)
            {
                theSmallestNum = a;
            }
            else if (b < a && b < c)
            {
                theSmallestNum = b;
            }
            else if (c < b && c < a)
            {
                theSmallestNum = c;
            }
            else if (a == b && b == c)
            {
                theSmallestNum = a;
            }

            Console.WriteLine(theSmallestNum);

        }
    }
}
