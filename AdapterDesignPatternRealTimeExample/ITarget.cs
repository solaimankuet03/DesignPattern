using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternRealTimeExample
{
    public interface ITarget
    {
        string TranslateAndTellToOtherPerson(string Words, string ConvertToWhichLanguage);
    }
}
