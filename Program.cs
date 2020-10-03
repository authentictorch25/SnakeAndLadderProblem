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
            const int NO_OF_PLAYERS = 2;
            Console.WriteLine("Welcome to Snake and Ladder");
            //initialising an array to store the data of 2 players separately 
            int[] PlayerCurrentPosition = new int[NO_OF_PLAYERS];

            for (int i = 0; i < NO_OF_PLAYERS; i++)
            
                PlayerCurrentPosition[i] = START_POSITION;
                int currentIndex = 0;
            
                

                while (PlayerCurrentPosition[currentIndex]<winningPlace)
                {
                    Random random = new Random();
                    bool flag = true;

                    while(flag)
                    {
                        int dieRoll = random.Next(1, 7);
                        int nextMove = random.Next(1, 4);
                        switch(nextMove)
                        {
                            case  NO_PLAY:
                                flag = false;
                                break;
                            case LADDER:
                                if(PlayerCurrentPosition[currentIndex]+dieRoll <= winningPlace)
                                PlayerCurrentPosition[currentIndex] += dieRoll;
                            if (PlayerCurrentPosition[currentIndex] == winningPlace)
                                flag = false;   
                                break;
                            case SNAKE:
                            
                            PlayerCurrentPosition[currentIndex] -= dieRoll;
                                if (PlayerCurrentPosition[currentIndex] < START_POSITION)
                                    PlayerCurrentPosition[currentIndex] = START_POSITION;
                            flag = false;

                            break;
                            default:
                                break;
                        }
                        Console.WriteLine("Current Player is " + (currentIndex + 1) + " Current Position is: " + PlayerCurrentPosition[currentIndex]);
                    }
                    numOfMoves++;
                    if (currentIndex < NO_OF_PLAYERS - 1)
                        currentIndex += 1;
                    else currentIndex = 0;
                }


            

            for (int i = 0; i < NO_OF_PLAYERS; i++)
            {
                Console.WriteLine("Player " + (i + 1) + ", Current Position " + PlayerCurrentPosition[i]);
            }
            Console.WriteLine("Total Turns used {0}", numOfMoves);
            Console.WriteLine("Winner is Player {0}", currentIndex + 1);





            Console.ReadKey();
        }
    }
}
