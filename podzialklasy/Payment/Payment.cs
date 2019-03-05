using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Payment
{
    public abstract class Payment
    {
        public abstract string Pay(decimal amount);
        //public abstract string Transfer(decimal amount);
        //public abstract string Card(decimal amount);
      
    }
}
