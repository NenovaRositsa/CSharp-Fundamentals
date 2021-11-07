using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokedTargets = 0;
            int originalValue = power;

            while (power >= distance)
            {
                if (power >= distance)
                {
                    pokedTargets++;
                    power -= distance;
                }

                if (power == (int)originalValue * 0.5 && exhaustionFactor != 0)
                {
                    power /= (int)exhaustionFactor;
                }


            }

            Console.WriteLine(power);
            Console.WriteLine(pokedTargets);

        }
    }
}
