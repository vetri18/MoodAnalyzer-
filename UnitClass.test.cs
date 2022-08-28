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
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string meassage = "I am in Sad Mood";
            string ExpectedOutput = "SAD";

            string result = moodAnalyzer.AnalyseMood(meassage);

            Assert.AreEqual(result, ExpectedOutput);

        }
    }
}