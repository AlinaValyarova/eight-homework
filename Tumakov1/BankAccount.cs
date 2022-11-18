using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov1
{
    public class BankAccount
    {
        private int ID { get; set; }
        private decimal Balance { get; set; }
        public enum AccType : byte
        {
            Saving,
            Current
        }
        private AccType Type { get; set; }


        public BankAccount() { }
        public BankAccount(int iD, decimal balance, AccType type)
        {
            ID = iD;
            Balance = balance;
            Type = type;

        }

 
        public void PutMoney(decimal money)
        {
            Balance += money;
            Console.WriteLine($"Balance: {Balance}");

            Transactions tracs = new Transactions(Balance);
        }
        public void TakeMoney(decimal money)
        {
            if (Balance > 0)
            {
                if (Balance - money > 0)
                {
                    Balance -= money;
                    Console.WriteLine($"Balance: {Balance}");
                    Transactions tracs = new Transactions(Balance);
                }
                else
                {
                    Console.WriteLine($"Not enougth money! Balance: {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Something is wrong!");
            }
        }

        public static int GenerateID(List<BankAccount> list, BankAccount acc1)
        {
            BankAccount acc2 = new BankAccount();
            int a = list.Count();
            acc1 = list[a];
            return acc2.ID = acc1.ID += 1;
        }

    }
}

