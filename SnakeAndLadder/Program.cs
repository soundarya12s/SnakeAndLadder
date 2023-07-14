using System;

namespace SnakeAndLadderPrg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Program");

            SnakeAndLadder snake = new SnakeAndLadder();
            snake.DieRoll();
            int player1 = snake.Game();
            SnakeAndLadder snake1 = new SnakeAndLadder();
            snake1.DieRoll();
            int player2 = snake1.Game();

            Console.WriteLine(player1 + " " + player2);

            if (player1.CompareTo(player2) > 0)
            {
                Console.WriteLine("Player 2");
            }
            else if (player1.CompareTo(player2) < 0)
            {
                Console.WriteLine("Player 1 ");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
