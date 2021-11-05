using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double totalPriceForLighsabers = countOfStudents * priceOfLightsaber;
            double moreLightsaber = Math.Ceiling(countOfStudents * 0.1) * priceOfLightsaber;
            totalPriceForLighsabers += moreLightsaber;
            double totalPriceforRobes = countOfStudents * priceOfRobe;
            double totalPriceForBelts = countOfStudents * priceOfBelt;

            if (countOfStudents >= 6)
            {
                for (int i = 1; i <= countOfStudents; i++)
                {
                    if (i % 6 == 0)
                    {
                        totalPriceForBelts -= priceOfBelt;
                    }
                }

            }

            double totalAmount = totalPriceForBelts + totalPriceForLighsabers + totalPriceforRobes;

            if (totalAmount <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalAmount:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalAmount - money):f2}lv more.");
            }



        }
    }
}
