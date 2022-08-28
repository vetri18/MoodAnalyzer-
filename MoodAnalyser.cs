using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodanalyzer
{
    public class MoodAnalyzer
    {
        public string message = "I am in Sad Mood";
        public string AnalyseMood(string msg)
        {
            if (this.message == msg)
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }

        }
    }
}