namespace SnakesAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;       // Position Initializin
            int dice = 0;      // Dice 
            int opt = 0;       // options


            Console.WriteLine("_______| Welcome! to Snake and Ladder Game |_______\n");
          
            Random random = new Random();       //Creating object random
            dice = random.Next(1, 7);       // Using random method 
            Console.WriteLine("The postition of player starts: {0} and random number of Dice: {1}\n", pos, dice);
            
            
            Random random1 = new Random();      //Creating object random
            opt = random1.Next(1, 4);        //Using random method

            switch (opt)         //Checking for options using switch case
            {
                case 1:
                    pos = pos + dice;
                    Console.WriteLine("The player moves ahead by number Dice value : " + pos);
                    break;
                case 2:
                    pos= pos - dice;
                    Console.WriteLine("The player moves behind by number Dice value : " + pos);
                    break;
                default:
                    Console.WriteLine("The player stay at same place : " + pos);
                    break;
            }

        }
    }
}