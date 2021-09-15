using System;

namespace SnakesAndLadders
{
    public class CheckInputs
    {
        //Check if the input is correctly introduce 
        public bool CheckNumberPlayers(string number)
        {
            if (checkNumber(number) == false)
                return false;
            return checkPlayers(int.Parse(number));
        }
        //Check if the input is a number
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
        //Check if the input is less than 6 and greater than 1
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
