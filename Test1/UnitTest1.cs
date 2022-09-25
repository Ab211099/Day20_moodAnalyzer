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
            UC1 mood = new UC1("I am in happy mood");
            
            string expected = "happy";
            var actual = mood.Mood();
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        [TestCategory("sad mood")]

        public void TestMethod2()
        {
            UC1 mood = new UC1("I am in sad mood");
            
            string expected = "sad";
            var actual = mood.Mood();
            Assert.AreEqual(expected,actual);
            Console.WriteLine(actual);
        }
       
       
        [TestMethod]
        [TestCategory("Empty Exception")]
        public void GivenEmptyShouldReturnCustomException()
        {
            string expected = "Message cann't be Empty";
            try
            {
               string message = "";
                UC1 mood = new UC1(message);    
                string actual = mood.Mood();
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Custom Exception: "+ex);
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Null Exception")]

        public void GivenNullShouldReturnCustomException()
        {
            string expected = "Message cann't be null";
            try
            {
                string message = null;
                UC1 mood = new UC1(message);
                string actual = mood.Mood();
            }
            catch(MoodAnalyzerException ex)
            {
                Console.WriteLine("Custom Exception " +ex);
                Assert.AreEqual(expected,ex.Message);
            }
        }


    }
}