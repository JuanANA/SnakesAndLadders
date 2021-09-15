using NUnit.Framework;
using SnakesAndLadders;

namespace NUnitTestSnakesAndLadders
{
    public class UniTestDie
    {
        [Test]
        public void TestDie()
        {
            Die die = new Die();
            //Test if the die give a result between 1 to 6
            Assert.Greater(die.RollDie(), 0);
            Assert.Less(die.RollDie(), 7);
        }
    }
}
