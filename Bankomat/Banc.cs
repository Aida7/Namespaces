using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Banc
    {
        public Client client;
        //private int balance;
        private string namberCard;
        public Banc()
        {
            namberCard = null;
        }
        public Banc(string namber)
        {
            this.namberCard = namber;
        }
    }
}
