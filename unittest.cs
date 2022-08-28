using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moodanalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood()
        {
            //Arrange

            string meassage = "I am in Sad Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(meassage);
            string ExpectedOutput = "SAD";

            string result = moodAnalyzer.AnalyseMood();

            Assert.AreEqual(result, ExpectedOutput);

        }
    }
}