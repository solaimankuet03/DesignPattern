using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternRealTimeExample
{
    public class John : IEnglishSpeaker
    {
        public string AskQuestions(string words)
        {
            Console.WriteLine("Question Asked by John [English Speaker and Can understand only English] : " + words);
            ITarget target = new Translator();
            string replyFromDavid = target.TranslateAndTellToOtherPerson(words, "French");
            return replyFromDavid;
        }

        public string AnswerForTheQuestion(string words)
        {
            string reply = null;
            if (words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "I am in USA";
            }
            return reply;
        }
    }
}
