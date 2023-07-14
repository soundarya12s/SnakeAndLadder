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
        bool WON=false;

        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7);
            count++;
           
            Console.Write(this.position+"| ");
            return diePosition;
        }
        public bool GetWon()
        {
            return WON;
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
                        if (this.position + dieRoll <= WINNING_POSITION)
                        {
                            this.position += dieRoll;
                        }
                       
                        break;
                    case SNAKE:
                        dieRoll = DieRoll();
                        if (this.position - dieRoll < STARTING_POSITION)
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

            if (this.position == WINNING_POSITION)
            {
                WON = true;
            }


            Console.WriteLine("\nNumber of times dice's played: " + count);
            return count;
        }
    }
}
