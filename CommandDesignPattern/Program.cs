using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program //client
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            ICommand openCommand = new OpenCommand(document);
            ICommand saveCommand = new SaveCommand(document);
            ICommand closeCommand = new CloseCommand(document);
            MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
            menu.ClickOpen();
            menu.ClickSave();
            menu.ClickClose();

            Console.ReadKey();
        }
    }
}
