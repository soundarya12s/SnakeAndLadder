using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        int position = 0;

        public void DieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);
            Console.WriteLine(diePosition);
        }
    }
}
