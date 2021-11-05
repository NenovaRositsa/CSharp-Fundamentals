using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double handsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0.00;
            int brokenHandset = 0;
            int brokenMouses = 0;
            int brokenKeyboards = 0;
            int brokenDisplays = 0;
            int countLostKeyboard = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    brokenHandset++;
                }
                if (i % 3 == 0)
                {
                    brokenMouses++;
                }
                if (i % 6 == 0)
                {
                    brokenKeyboards++;
                    countLostKeyboard++;

                    if (countLostKeyboard % 2 == 0)
                    {
                        brokenDisplays++;
                    }


                }

            }

            rageExpenses = (brokenHandset * handsetPrice) + (brokenMouses * mousePrice) + (brokenKeyboards * keyboardPrice) + (brokenDisplays * displayPrice);

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
