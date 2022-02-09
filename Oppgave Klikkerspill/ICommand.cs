using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Klikkerspill
{
    public interface ICommand
    { 
        char Character { get; }
        void Run();

    }
}
