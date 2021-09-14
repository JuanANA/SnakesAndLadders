using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    class CheckInputs
    {
        public bool CheckNumberPlayers(string number)
        {
            if (checkNumber(number) == false)
                return false;
            return checkPlayers(int.Parse(number));
        }
        private bool checkNumber(string number)
        {
            int result;
            if (int.TryParse(number, out result))
            {
                return true;
            }
            Console.WriteLine("Must introduce a number");
            return false;
        }
        private bool checkPlayers(int number)
        {
            if (number > 5)
            {
                Console.WriteLine("Must introduce a number smaller than 6");
                return false;
            }
            if (number < 2)
            {
                Console.WriteLine("Must introduce a number upper than 1");
                return false;
            }
            return true;           
        }        
    }
}
