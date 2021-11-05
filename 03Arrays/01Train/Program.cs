using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peopleInEachWagon = new int[wagons];
            int people = 0;

            for (int i = 0; i < wagons; i++)
            {
                int peopleInCurrentWagon = int.Parse(Console.ReadLine());
                peopleInEachWagon[i] = peopleInCurrentWagon;
                people += peopleInCurrentWagon;

            }


            Console.WriteLine(string.Join(" ", peopleInEachWagon));
            Console.WriteLine(people);
        }
    }
}
