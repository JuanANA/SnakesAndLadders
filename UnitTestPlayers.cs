using NUnit.Framework;
using SnakesAndLadders;

namespace NUnitTestSnakesAndLadders
{
    public class UnitTestPlayers
    {
        [Test]
        public void TestPlayers()
        {
            Players players = new Players();
            players.AssignNumbersPlayers(2);
            //Test if the players number is 2
            Assert.AreEqual(players.NumberPlayers, 2);
            //Test if the positions number is 2
            Assert.AreEqual(players.Positions.Length, 2);
            //Test if the firts token has position 1
            Assert.AreEqual(players.Positions[0], 1);
            //Test if the second token has position 1
            Assert.AreEqual(players.Positions[1], 1);
        }
    }
}
