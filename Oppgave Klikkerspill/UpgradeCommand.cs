using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Klikkerspill
{
    internal class UpgradeCommand : ICommand
    {
        public char Character { get; }
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
