using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
     public class Client
    {
        private string nameClient;
        private int namberScore;
        private int balanced;
        public Client()
        {
            nameClient = null;
            namberScore = 0;
        }

        public Client(string name, int nam)
        {
            this.nameClient = name;
            this.namberScore = nam;
        }
        public void Balance(int balance)
        {
            this.balanced = balance;
            Console.WriteLine("ваш баланс {0}", balance);
        }
        public void Refill(int balance,int namberMany)
        {
            int count = balance + namberMany;
            Console.WriteLine("ваш счет {0}", count);
        }
       
        public void WithdrawMoney(int balance, int namberMany)
        {
            int count = balance - namberMany;
            Console.WriteLine("ваш счет {0}", count);

        }
    }
}
