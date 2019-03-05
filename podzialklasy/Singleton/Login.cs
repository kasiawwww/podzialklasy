using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podzialklasy.Singleton
{
    public class Login
    {
        private static Login instance;
        public string Username { get; private set; }
        public string Password { get; private set; }
        protected Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public static Login Instance(string username, string password)
        {
            if (instance == null)
            {
                instance = new Login(username, password);         
            }
            return instance;
        }
    }
}
