using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int length = firstPlayer.Count;

            for (int i = 0; i < length; i++)
            {
                int currentNumFirstPlayer = firstPlayer[i];
                int currentNumSecondPlayer = secondPlayer[i];

                if (currentNumFirstPlayer == currentNumSecondPlayer)
                {
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                    i--;

                    if (firstPlayer.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
                        return;
                    }
                    if (secondPlayer.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
                        return;
                    }
                }
                else if (currentNumFirstPlayer > currentNumSecondPlayer)
                {
                    firstPlayer.Add(currentNumFirstPlayer);
                    firstPlayer.Add(currentNumSecondPlayer);
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                    i--;
                    if (firstPlayer.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
                        return;
                    }
                    if (secondPlayer.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
                        return;
                    }
                    

                }
                else
                {
                   secondPlayer.Add(currentNumSecondPlayer);
                   secondPlayer.Add(currentNumFirstPlayer);
                   secondPlayer.RemoveAt(i);
                   firstPlayer.RemoveAt(i);
                    i--;
                    if (firstPlayer.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
                        return;
                    }
                    if (secondPlayer.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
                        return;
                    }
                }

            }
        }
    }
}
