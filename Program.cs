using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");
            const int START_POSITION = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("The number appeared is {0}", dieRoll);
            Console.ReadKey();
        }
    }
}
