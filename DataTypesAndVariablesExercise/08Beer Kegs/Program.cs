using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double volumeKeg = 0.00;
            string modelOfTheBiggestKeg = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolumeKeg = Math.PI * Math.Pow(radius, 2) * height;

                if (currentVolumeKeg >= volumeKeg)
                {
                    volumeKeg = currentVolumeKeg;
                    modelOfTheBiggestKeg = model;

                }

            }

            Console.WriteLine(modelOfTheBiggestKeg);
        }
    }
}
