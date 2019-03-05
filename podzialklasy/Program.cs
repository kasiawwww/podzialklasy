using podzialklasy.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy
{
    class Program
    {
        static void Main(string[] args)
        {
            CardPayment payment = new CardPayment();
            Console.WriteLine(payment.Pay(100));
            Console.ReadLine();
        }
    }
}
