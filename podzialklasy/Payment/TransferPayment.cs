using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Payment
{
    class TransferPayment: Payment
    {
        public override string Pay(decimal amount)
        {
            return $"Płatnośc przelewem - {amount}";
        }
    }
}
