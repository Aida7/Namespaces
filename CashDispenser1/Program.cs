using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat;
using CashDispenser1;
namespace CashDispenser1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AddClient();
            p.TrueAccount();
        }

        List<Account> clientList = new List<Account>();
        List<Client> client = new List<Client>();
        private string name;
        private string password;
        private string log;
        private int namber;

        public void AddClient()
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.WriteLine("Номера логин");
            log = Console.ReadLine();
            Console.WriteLine("введите пароль");
            password = Console.ReadLine();
            Console.WriteLine("введите номер карточки");
            int.TryParse(Console.ReadLine(), out namber);
            Client client = new Client(name, namber);
            Account tmp = new Account(name, log, password);

            clientList.Add(tmp);
        }

        public void ShowMenu()
        {
            Client client1 = new Client();
            int many, balance1 = 100;


            Console.WriteLine("1. вывод баланса на экран");
            Console.WriteLine("2. пополнение счёта");
            Console.WriteLine("3. снять деньги со счёта");
            Console.WriteLine("4.  Выход");
            char ch;
            char.TryParse(Console.ReadLine(),out ch);
            switch (ch)
            {
                case '1': client1.Balance(balance1); break;

                case '2':
                    Console.WriteLine("new many ="); int.TryParse(Console.ReadLine(), out many);
                    client1.Refill(balance1, many); break;

                case '3':
                    Console.WriteLine("new many ="); int.TryParse(Console.ReadLine(), out many);
                    client1.Refill(balance1, many); break;

                case '4': break;

                default: Console.WriteLine("такого пункта не существует"); break;
            }
        }

        public void TrueAccount()
        {
            Console.WriteLine("Введите логин");
            log = Console.ReadLine();
            Console.WriteLine("введите пароль");
            password = Console.ReadLine();
            Account tmp1 = new Account();

            for (int i = 0; i < 3; i++)
            {
                tmp1.TryAccount(log, password);
                if (tmp1.TryAccount(log, password) == false)
                {
                    Console.WriteLine("пароль правельно ввели");
                    Console.WriteLine("\n______________________________\n");
                    ShowMenu();
                    Console.ReadLine();
                }
                else
                {
                    i++;
                }
            }
            }
        }   
    }
    

