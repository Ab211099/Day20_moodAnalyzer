using MoodAnalyzer;
using System.Security.Cryptography.X509Certificates;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            [TestCategory("Happy mood")]
        public void TestMethod1()
        {
            UC1 mood = new UC1();
            string message = "I am in happy mood";
            string expected = "happy";
            var actual = mood.Mood(message);
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        [TestCategory("sad mood")]

        public void TestMethod2()
        {
            UC1 mood = new UC1();
            string message = "I am in sad mood";
            string expected = "Sad";
            var actual = mood.Mood(message);
            Assert.AreEqual(expected,actual);
            Console.WriteLine(actual);
        }


    }
}