﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Messenger
{
    class SMS : IMessageProvider
    {
        public string Send()
        {
            return "SMS";
        }
    }
}
