﻿using System;

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

            Console.WriteLine("Welcome to Snake and Ladder");
            
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("The number appeared is {0}", dieRoll);
           
            int option = random.Next(1, 4);
            switch(option)
            {
                case NO_PLAY:
                    break;

                case LADDER:
                    currentPosition += dieRoll;
                    break;
                case SNAKE:
                    currentPosition -= dieRoll;
                    break;

            }
            Console.WriteLine("The current Position is {0}", currentPosition);
            Console.ReadKey();
        }
    }
}
