using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            int capacityTank = 0;

            for (int i = 0; i < countLines; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());

                if (litersOfWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                capacityTank += litersOfWater;

                if (capacityTank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacityTank -= litersOfWater;
                    continue;
                }

            }

            Console.WriteLine(capacityTank);
        }
    }
}
