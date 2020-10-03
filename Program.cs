using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int START_POSITION = 0;
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE = 3;
            int currentPosition = START_POSITION;
            int winningPlace = 100;
            int numOfMoves = 0;

            Console.WriteLine("Welcome to Snake and Ladder");
            Random random = new Random();


            while (currentPosition < winningPlace)
            {               
                int dieRoll = random.Next(1, 7);
               // Console.WriteLine("The number appeared is {0}", dieRoll);
                int option = random.Next(1, 4);
               // Console.WriteLine("Next move : {0}", option);

                switch (option)
                {
                    case NO_PLAY:
                        break;

                    case LADDER:
                        if (currentPosition + dieRoll <= winningPlace)
                        {
                            currentPosition += dieRoll;
                        }
                        break;
                    case SNAKE:
                        currentPosition -= dieRoll;
                        if (currentPosition < START_POSITION)
                        {
                            currentPosition = START_POSITION;
                        }
                        break;
                }
                numOfMoves++;
            }
            Console.WriteLine("The current Position is {0}", currentPosition);
            Console.WriteLine("Total moves used {0}", numOfMoves);
            Console.ReadKey();
        }
    }
}
