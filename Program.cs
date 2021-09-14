using System;

namespace SnakesAndLadders
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snakes and Ladders, I hope you enjoy and spend a good time, good luck");
            Console.WriteLine("How many players are going to play?");
            Players players = new Players();
            CheckInputs checkInputs = new CheckInputs();
            string line = Console.ReadLine();
            while (checkInputs.CheckNumberPlayers(line) == false)
            {
                line = Console.ReadLine();
            }
            players.AssignNumbersPlayers(int.Parse(line));            
            Console.WriteLine("Ok, let´s play");
            Die die = new Die();
            Square square = new Square();
            int turn = 0;
            while (players.Positions[turn] != 100)
            {
                int result = die.RollDie();
                Console.WriteLine("Player " + (turn + 1 ) + " roll the die and result is a " + result);
                players.Positions[turn]= square.CheckSquare(players.Positions[turn], result);                
                Console.WriteLine("Player " + (turn + 1) + " move to square " + players.Positions[turn]);
                turn++;
                if (turn == players.NumberPlayers)
                {
                    turn = 0;
                }
            }
            Console.WriteLine("Player " + (turn + 1) + " ¡¡¡WIN!!!");
        }
    }
}
