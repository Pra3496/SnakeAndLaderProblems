﻿namespace SnakesAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;       // Position Initializin
            int dice = 0;      // Dice 
            int opt = 0;       // options
            int winCnt = 0;


            Console.WriteLine("_______| Welcome! to Snake and Ladder Game |_______\n");
          
            Random random = new Random();       //Creating object random

            Random random1 = new Random();      //Creating object random

            Console.WriteLine("\nThe postition of player starts: {0} and random number of Dice: {1}\n\n", pos, dice);
           

            while(pos < 100)
            {
                dice = random.Next(1, 7); // Using random method 
                opt = random1.Next(1, 4); //Using random method
                winCnt++;

                switch (opt)         //Checking for options using switch case
                {
                    case 1:
                        pos = pos + dice;

                        if(pos > 100)
                        {
                            pos = 100;
                        }
                        Console.WriteLine("\nThe player moves ahead by number Dice value : " + pos);
                        break;
                    case 2:
                        pos = pos - dice;
                        if(pos < 0)
                        {
                            pos = 0;
                        }
                        Console.WriteLine("\nThe player moves behind by number Dice value : " + pos);
                        break;
                    default:
                        Console.WriteLine("\nThe player stay at same place : " + pos);
                        break;
                }

            }

            Console.WriteLine("\n\n\n----------------------------END----------------------------\n");
            Console.WriteLine("\t{0} times the dice was played to win the game ", winCnt);
            Console.WriteLine("-----------------------------------------------------------\n");
        }
    }
}