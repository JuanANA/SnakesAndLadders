using NUnit.Framework;
using SnakesAndLadders;

namespace NUnitTestSnakesAndLadders
{
    public class UniTestCheckInputs
    {
        [Test]
        public void TestCheckInputs()
        {
            CheckInputs checkInputs = new CheckInputs();
            //Test if the player numbers is less than 2
            Assert.AreEqual(checkInputs.CheckNumberPlayers("1"), false);
            //Test if the player numbers is between 2 to 6
            Assert.AreEqual(checkInputs.CheckNumberPlayers("2"), true);
            //Test if the player numbers is greater than 6
            Assert.AreEqual(checkInputs.CheckNumberPlayers("7"), false);
        }
    }
}
