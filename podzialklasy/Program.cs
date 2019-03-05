using podzialklasy.Messenger;
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
            //CardPayment payment = new CardPayment();
            //Console.WriteLine(payment.Pay(100));

            Messenger.Messenger messenger = new Messenger.Messenger();
            List<IMessageProvider> list = new List<IMessageProvider>();
            list.Add(new SMS());
            list.Add(new Email());
            list.Add(new MMS());
            Console.WriteLine(messenger.SendMessages(list)); 

            Console.ReadLine();
        }
    }
}
