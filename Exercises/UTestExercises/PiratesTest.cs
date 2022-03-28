using System.Collections.Generic;
using Exercises;
using NUnit.Framework;

namespace UTestExercises3
{
    public class Tests
    {
        [Test, Description("should fire the cannons when ready")]
        public void SampleAyeTest()
        {
            Pirates p1 = new Pirates();
            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
              {"Mike", "aye"},
              {"Joe", "aye"},
              {"Johnson", "aye"},
              {"Peter", "aye"}
            };

            Assert.AreEqual("Fire!", p1.CannonsReady(gunners));
        }
        [Test, Description("should shiver me timbers if not ready")]
        public void SampleNayTest()
        {
            Pirates p1 = new Pirates();
            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
              {"Mike", "aye"},
              {"Joe", "nay"},
              {"Johnson", "aye"},
              {"Peter", "aye"}
            };

            Assert.AreEqual("Shiver me timbers!", p1.CannonsReady(gunners));
        }
    }
}
