using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource;
            Dictionary<string, int> mine = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(resource))
                {
                    mine.Add(resource, quantity);
                }
                else
                {
                    mine[resource] += quantity;
                }
            }

            foreach (var item in mine)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
