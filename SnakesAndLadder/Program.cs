namespace SnakesAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;  // Position
            int dice = 0; // Dice
            
            Console.WriteLine("Welcome! to Snake and Ladder Game");

            //Position Initializing

            Random random = new Random();

            dice = random.Next(1, 7);

            Console.WriteLine("The position of player starts: {0} and random number of Dice: {1}",pos,dice);

        }
    }
}