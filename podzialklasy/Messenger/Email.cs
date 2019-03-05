using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Messenger
{
    public class Email : IMessageProvider
    {
        public string Send()
        {
            return "Email";
        }
    }
}
