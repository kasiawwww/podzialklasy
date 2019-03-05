using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Door
{
    class SmartDoor: ISmartDoor
    {
        public string AutomaticClosing()
        {
            return "Zamykam zdalnie";
        }

        public string AutomaticOpening()
        {
            return "Otwieram zdalnie";
        }

        public string Close()
        {
           return "Zamykam ręcznie";
        }

        public string Open()
        {
            return "Otwieram ręcznie";
        }
    }
}
