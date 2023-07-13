using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and ladder Program");
            SnakeAndLadder snake = new SnakeAndLadder();
            snake.DieRoll();
            snake.Game();

        }
    }
}