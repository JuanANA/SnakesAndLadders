using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Board
    {
        //Square in which the token is placed
        private List<int> _squarePlaced;
        private List<int> squarePlaced
        {
            get { return _squarePlaced; }
            set { _squarePlaced = value; }
        }
        //Square in which the token has a special move
        private List<int> _squareToChanged;
        private List<int> squareToChanged
        {
            get { return _squareToChanged; }
            set { _squareToChanged = value; }
        }

        public Board()
        {
            //Initialize all special squares
            squarePlaced = new List<int>();
            squareToChanged = new List<int>();
            squarePlaced.Add(2);
            squareToChanged.Add(38);
            squarePlaced.Add(7);
            squareToChanged.Add(14);
            squarePlaced.Add(8);
            squareToChanged.Add(31);
            squarePlaced.Add(15);
            squareToChanged.Add(26);
            squarePlaced.Add(16);
            squareToChanged.Add(6);
            squarePlaced.Add(28);
            squareToChanged.Add(84);
            squarePlaced.Add(36);
            squareToChanged.Add(44);
            squarePlaced.Add(46);
            squareToChanged.Add(25);
            squarePlaced.Add(49);
            squareToChanged.Add(11);
            squarePlaced.Add(51);
            squareToChanged.Add(67);
            squarePlaced.Add(62);
            squareToChanged.Add(19);
            squarePlaced.Add(64);
            squareToChanged.Add(60);
            squarePlaced.Add(71);
            squareToChanged.Add(91);
            squarePlaced.Add(74);
            squareToChanged.Add(53);
            squarePlaced.Add(78);
            squareToChanged.Add(98);
            squarePlaced.Add(87);
            squareToChanged.Add(94);
            squarePlaced.Add(89);
            squareToChanged.Add(68);
            squarePlaced.Add(92);
            squareToChanged.Add(88);
            squarePlaced.Add(95);
            squareToChanged.Add(75);
            squarePlaced.Add(99);
            squareToChanged.Add(80);
        }
        //Check the square where token is placed
        public int CheckSquare(int square, int dice)
        {
            //New token movement
            int moveTo = square + dice;
            //If the move is greater than 100, the token stays in the same square
            if (moveTo > 100)
            {
                return square;
            }
            else
            {
                //If token is placed on a special square
                if (squarePlaced.Contains(moveTo))
                {
                    //If token has to go forward is good luck, if not bad luck
                    int index = squarePlaced.LastIndexOf(moveTo);
                    if (squarePlaced[index] < squareToChanged[index])
                    {
                        Console.WriteLine("Good luck!, move to square " + squareToChanged[index]);
                        return squareToChanged[index];
                    }
                    else
                    {
                        Console.WriteLine("Bad luck!, move to square " + squareToChanged[index]);
                        return squareToChanged[index];
                    }
                }                
                return moveTo;
            }
        }
    }
}
