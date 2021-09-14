using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    class Die
    {
        public int RollDie()
        {
            Random rand = new Random();
            return rand.Next(1, 6);
        }
    }
}
