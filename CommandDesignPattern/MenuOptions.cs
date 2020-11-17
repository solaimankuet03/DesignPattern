using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class MenuOptions //invoker
    {
        private ICommand openCommand;
        private ICommand closeCommand;
        private ICommand saveCommand;

        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.closeCommand = close;
            this.saveCommand = save;
        }

        public void ClickOpen()
        {
            openCommand.Execute();
        }

        public void ClickSave()
        {
            saveCommand.Execute();
        }

        public void ClickClose()
        {
            closeCommand.Execute();
        }
    }
}
