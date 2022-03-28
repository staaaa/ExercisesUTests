using Exercises;
using NUnit.Framework;

namespace UTestExercises2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void StringSort()
        {
            StringSort s1 = new StringSort();
            Assert.AreEqual("aehrsty", s1.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", s1.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", s1.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}
