using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Account
    {
        private string nameClient;
        private string login;
        private string password;
        public Account()
        {
            nameClient = null;
            login = null;
            password = null;
        }
        public Account(string name, string log, string password)
        {
            this.nameClient = name;
            this.login = log;
            this.password = password;
        }
        public bool TryAccount(string log, string parole)
        {
            if (login == log && password == parole)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
