using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Door
{
    class WoodenDoor : IWoodenDoor
    {
        public string Close()
        {
            return "Zamykam";
        }

        public int Glasses()
        {
            return 1;
        }
        public string Open()
        {
            return "Otwieram";
        }
    }
}
