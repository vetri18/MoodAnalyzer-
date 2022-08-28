using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Moodanalyzer
{
    public class MoodAnalyserFactory1
    {
        public static object Refelection_Using_Parameterized_Constructor(string clasName, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyzer);
            if (type.Name.Equals(constructorName) || type.FullName.Equals(clasName))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object intance = ctor.Invoke(new object[] { message });
                    return intance;
                }
                else
                {
                    throw new InvalidMoodException(InvalidMoodException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new InvalidMoodException(InvalidMoodException.ExceptionType.NO_SUCH_CLASS, "Class not found");
            }
        }


        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("Moodanalyzer.MoodAnalyzer");
                object moodAnalyseObject = MoodAnalyserFactory1.Refelection_Using_Parameterized_Constructor("Moodanalyzer.MoodAnalyzer", "MoodAnalyzer", message);
                MethodInfo analysemoodInfo = type.GetMethod(methodName);
                object mood = analysemoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new InvalidMoodException(InvalidMoodException.ExceptionType.NO_SUCH_METHOD, "Method is not found");
            }
        }
    }
}