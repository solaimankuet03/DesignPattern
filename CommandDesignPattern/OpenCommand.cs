using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class OpenCommand : ICommand
    {
        private Document _document;

        public OpenCommand(Document doc)
        {
            _document = doc;
        }

        public void Execute()
        {
            _document.Open();
        }
    }

    public class CloseCommand : ICommand
    {
        private Document _document;

        public CloseCommand(Document doc)
        {
            _document = doc;
        }

        public void Execute()
        {
            _document.Close();
        }
    }

    public class SaveCommand : ICommand
    {
        private Document _document;

        public SaveCommand(Document doc)
        {
            _document = doc;
        }

        public void Execute()
        {
            _document.Save();
        }
    }
}
