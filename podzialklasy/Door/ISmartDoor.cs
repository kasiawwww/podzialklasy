using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Door
{
    interface ISmartDoor: IDoor
    {
        string AutomaticClosing();
        string AutomaticOpening();
    }
}
