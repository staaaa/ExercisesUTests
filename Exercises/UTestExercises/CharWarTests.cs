using Exercises;
using NUnit.Framework;

namespace UTestExercises4
{
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            CharWar c1 = new CharWar();
            Assert.AreEqual("Z", c1.Battle("AAA", "Z"));
            Assert.AreEqual("TWO", c1.Battle("ONE", "TWO"));
            Assert.AreEqual("Tie!", c1.Battle("ONE", "NEO"));
            Assert.AreEqual("FOUR", c1.Battle("FOUR", "FIVE"));
        }
    }
}
