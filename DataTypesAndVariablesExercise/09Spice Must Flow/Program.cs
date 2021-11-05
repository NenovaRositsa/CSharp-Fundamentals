using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int extractedSpices = 0;
            int counterDays = 0;

            while (startingYield >= 100)
            {
                extractedSpices += startingYield;
                startingYield -= 10;
                counterDays++;


                if (extractedSpices >= 26)
                {
                    extractedSpices -= 26;
                }



                else
                {
                    Console.WriteLine(counterDays);
                    Console.WriteLine(extractedSpices);
                    return;
                }

            }

            if (extractedSpices >= 26)
            {
                extractedSpices -= 26;
            }


            Console.WriteLine(counterDays);
            Console.WriteLine(extractedSpices);


        }
    }
}
