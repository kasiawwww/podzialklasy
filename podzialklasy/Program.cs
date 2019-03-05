using podzialklasy.KISS;
using podzialklasy.Messenger;
using podzialklasy.Payment;
using podzialklasy.Singleton;
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

            //Messenger.Messenger messenger = new Messenger.Messenger();
            //List<IMessageProvider> list = new List<IMessageProvider>();
            //list.Add(new SMS());
            //list.Add(new Email());
            //list.Add(new MMS());
            //Console.WriteLine(messenger.SendMessages(list)); 

            //XY xy = new XY();
            // Console.WriteLine(xy.DoThis(2,4)); 
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            Login l = Login.Instance(username, password);
            Console.WriteLine("Object created");
            Console.WriteLine("press a key");
            Console.ReadKey();
            Console.WriteLine($"Login {l.Username}, Password:  {l.Password}");

            Console.ReadLine();
        }
    }
}
