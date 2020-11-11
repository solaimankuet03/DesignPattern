using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternRealTimeExample
{
    public interface IFrenchSpeaker
    {
        string AskQuestions(string words);
        string AnswerForTheQuestion(string words);
    }
}
