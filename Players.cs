namespace SnakesAndLadders
{
    public class Players
    {
        //Property to control the number of players
        int _numberPlayers;        
        public int NumberPlayers
        {
            get { return _numberPlayers; }
            set { _numberPlayers = value; }
        }
        //Property to control the position of players
        int[] _positions;
        public int[] Positions
        {
            get { return _positions; }
            set { _positions = value; }
        }
        //Assign the number of players
        public void AssignNumbersPlayers(int jugadores)
        {
            NumberPlayers = jugadores;
            Positions = new int[jugadores];
            //Initialize position of each token
            for(int i = 0; i < jugadores; i++)
            {
                Positions[i] = 1;
            }
        }
    }
}
