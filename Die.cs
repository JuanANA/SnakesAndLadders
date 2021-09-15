using System;

namespace SnakesAndLadders
{
    public class Die
    {
        //Roll the die
        public int RollDie()
        {
            Random rand = new Random();
            return rand.Next(1, 6);
        }
    }
}
