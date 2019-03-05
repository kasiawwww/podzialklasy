using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Messenger
{
    class Messenger
    {
        public string SendMessages (List<IMessageProvider> messages) 
        {
            string result = $"Wysyłam widomość za pomocą: ";
            foreach (var item in messages)
            {               
                result = result + item.Send();
            }
            return result;
        }
    }
}
