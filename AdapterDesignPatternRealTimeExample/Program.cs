using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternRealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string replyFromDavid = new John().AskQuestions("how are you?");
            Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
            Console.WriteLine();

            string replyFromJohn = new David().AskQuestions("où êtes-vous?");
            Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);

            Console.Read();
        }
    }
}
