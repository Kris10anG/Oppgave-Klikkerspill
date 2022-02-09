using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Klikkerspill
{
    internal class CommandSet 
    {
        private ICommand[] CommandList;

        public CommandSet()
        {
            CommandList = new ICommand[4];
            ClickCommand Click = new ClickCommand()
        }
    }
}
