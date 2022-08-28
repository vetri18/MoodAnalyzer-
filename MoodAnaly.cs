using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodanalyzer
{
    public class MoodAnalyzer
    {
        private const string message = "I am in Sad Mood";
        private string testmessage = "";
        //public string Message
        //{ 
        //    get { return message; } 
        //    set { message = value; }
        //}
        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer(string msg)
        {
            this.testmessage = msg;
        }

        public string AnalyseMood()
        {

            try

            {
                if (this.testmessage == "NULL" || this.testmessage == string.Empty)
                {
                    throw new Exception("Mood is Null");
                }

                if (this.testmessage == message)
                {
                    return "SAD";
                }
                else if (this.testmessage == "I am in Happy Mood")
                {
                    return "Happy";
                }
                else
                {
                    throw new Exception("Mood is Null");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Happy";
            }


        }
    }
}