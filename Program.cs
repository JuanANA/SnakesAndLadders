using System;

namespace SnakesAndLadders
{
    class Program
    {   
        //Main function that starts the application
        static void Main(string[] args)
        {
            //Start the application
            Console.WriteLine("Welcome to Snakes and Ladders, I hope you enjoy and spend a good time, good luck");
            Console.WriteLine("How many players are going to play?");
            //Create the players
            Players players = new Players();
            //Create checks for inputs
            CheckInputs checkInputs = new CheckInputs();
            //Get input from the console
            string line = Console.ReadLine();
            //Check that the input is correct and ask until it is correct
            while (checkInputs.CheckNumberPlayers(line) == false)
            {
                //Get input from the console
                line = Console.ReadLine();
            }
            //Assign players numbers 
            players.AssignNumbersPlayers(int.Parse(line));   
            //Start the game
            Console.WriteLine("Ok, let´s play");
            //Create the die
            Die die = new Die();
            //Create the board
            Board board = new Board();
            int turn = 0;
            //Roll the die and move each player until one player gets the 100 square
            while (players.Positions[turn] != 100)
            {
                //Roll the die
                int result = die.RollDie();
                //Show the result
                Console.WriteLine("Player " + (turn + 1 ) + " roll the die and result is a " + result);
                //Check the square where the token is placed
                players.Positions[turn]= board.CheckSquare(players.Positions[turn], result);
                //Show where the token is placed
                Console.WriteLine("Player " + (turn + 1) + " move to square " + players.Positions[turn]);
                //Change the turn to the next player
                turn++;
                //The first player starts when all players roll the die
                if (turn == players.NumberPlayers)
                {
                    turn = 0;
                }
            }
            //Show the winnig player
            Console.WriteLine("Player " + (turn + 1) + " ¡¡¡WIN!!!");
        }
    }
}
