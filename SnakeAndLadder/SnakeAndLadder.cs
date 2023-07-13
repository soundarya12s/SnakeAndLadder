using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int position = 0;

        Random random = new Random();
        public int DieRoll()
        {
            
            int diePosition = random.Next(1, 7);
            Console.WriteLine(diePosition);
            return diePosition;
        }

        public void Game()
        {
            while (this.position < WINNING_POSITION)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.position += DieRoll();
                        break;
                    case SNAKE:
                        int dieRoll = DieRoll();
                        if (this.position - dieRoll < 0)
                        {
                            this.position = 0;
                        }
                        else
                        {
                            this.position -= DieRoll();
                        }
                        break;
                }
            }
        }
     }
}
