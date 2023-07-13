using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderPrg
{
    public class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100, STARTING_POSITION = 0;
        int position = 0, count = 0;

        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7);
            Console.WriteLine("Player position: " + diePosition);
            count++;
            return diePosition;
        }
        public int Game()
        {
            while (this.position < WINNING_POSITION)
            {

                int option = random.Next(0, 3);
                switch (option)
                {

                    case NO_PLAY:
                        break;
                    case LADDER:
                        int dieRoll = DieRoll();
                        if (this.position + dieRoll < 100)
                        {
                            this.position += dieRoll;
                        }
                        this.position += DieRoll();
                        break;
                    case SNAKE:
                        dieRoll = DieRoll();
                        if (this.position - dieRoll < 0)
                        {
                            this.position = 0;
                        }
                        else
                        {
                            this.position -= dieRoll;
                        }

                        break;
                }
            }
            Console.WriteLine("Number of times dice's played; " + count);
            return count;
        }
    }
}
