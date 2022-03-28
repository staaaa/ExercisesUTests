using Exercises;
using NUnit.Framework;

namespace UTestExercises1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void AreEven()
        {
            AreEven a1 = new AreEven();
            Assert.AreEqual("Even", a1.EvenOrOdd(2));
            Assert.AreEqual("Odd", a1.EvenOrOdd(1));
            Assert.AreEqual("Even", a1.EvenOrOdd(0));
            Assert.AreEqual("Odd", a1.EvenOrOdd(7));
            Assert.AreEqual("Odd", a1.EvenOrOdd(-1));
        }
    }
}
