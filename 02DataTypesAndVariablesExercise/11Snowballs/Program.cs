using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());

            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;
            BigInteger maxValue = 0;

            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;


                }

            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxValue} ({maxSnowballQuality})");



        }
    }
}
