using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Payment
{
    class CardPayment: Payment
    {
        public override string Pay(decimal amount)
        {
            return $"Płatnośc kartą - {amount}";
        }
 
    }
}
