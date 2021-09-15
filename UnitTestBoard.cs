using NUnit.Framework;
using SnakesAndLadders;

namespace NUnitTestSnakesAndLadders
{
    public class NUnitTestSnakesAndLadders
    {
        [Test]
        public void TestBoard()
        {
            Board board = new Board();
            //Test if the token is placed in a special square that it has to go forward
            Assert.AreEqual(board.CheckSquare(1,1),38);
            //Test if the token is placed in a special square that it has to go back
            Assert.AreEqual(board.CheckSquare(10, 6), 6);
            //Test if the token is placed in a normal square
            Assert.AreEqual(board.CheckSquare(3, 3), 6);
            //Test if the token tries to move more than 100 square
            Assert.AreEqual(board.CheckSquare(98, 3), 98);
        }
    }
}