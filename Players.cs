using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders
{
    class Players
    {
        int _numberPlayers;
        int[] _positions;
        public int NumberPlayers
        {
            get { return _numberPlayers; }
            set { _numberPlayers = value; }
        }
        public int[] Positions
        {
            get { return _positions; }
            set { _positions = value; }
        }
        public void AssignNumbersPlayers(int jugadores)
        {
            NumberPlayers = jugadores;
            Positions = new int[jugadores];
            for(int i = 0; i < jugadores; i++)
            {
                Positions[i] = 1;
            }
        }
    }
}
