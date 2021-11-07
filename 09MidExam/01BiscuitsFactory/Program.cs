using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscuits_Factory_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int workerBiscuits = int.Parse(Console.ReadLine());
            int coutWorkers = int.Parse(Console.ReadLine());
            int biscuitsCompetingFactory = int.Parse(Console.ReadLine());
            int biscuitsForDay = workerBiscuits * coutWorkers;
            int thirdDayBiscuits = (int)(biscuitsForDay * 0.75);
            int totalBiscuits = 0;

            for (int i = 1; i <=  30; i++)
            {
                if (i %3 != 0)
                {
                    totalBiscuits += biscuitsForDay;
                }
                else
                {
                    totalBiscuits += thirdDayBiscuits;
                }
                
                
            }

            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

            double difference = totalBiscuits - biscuitsCompetingFactory;

            if (difference > 0)
            {
                Console.WriteLine($"You produce {(difference/biscuitsCompetingFactory * 100):f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {Math.Abs((difference / biscuitsCompetingFactory * 100)):f2} percent less biscuits.");
            }

        }
    }
}
