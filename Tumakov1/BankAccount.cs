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
        private System.Collections.Queue Queue;
        private int ID { get; set; }
        private decimal Balance { get; set; }
        public enum Acc_Type : byte
        {
            Saving,
            Current
        }
        private Acc_Type Type { get; set; }


        public BankAccount() { }
        public BankAccount(int iD, decimal balance, Acc_Type type)
        {
            ID = iD;
            Balance = balance;
            Type = type;

        }

 
        public void PutMoney(decimal money)
        {
            Balance += money;
            Console.WriteLine($"Balance: {Balance}");
            Queue.Enqueue(new Transactions(money));


        }
        public void TakeMoney(decimal money)
        {
            if (Balance > 0)
            {
                if (Balance - money > 0)
                {
                    Balance -= money;
                    Console.WriteLine($"Balance: {Balance}");
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
            Queue.Enqueue(new Transactions(money));
        }
        public void Transition(BankAccount acc1, decimal perevod)
        {
            if (acc1.Balance > perevod)
            {
                acc1.Balance -= perevod;
                Balance += perevod;
            }
            else
            {
                Console.WriteLine("Not enought money");
            }
        }
        public void Dispose()
        {
            foreach (var i in Queue)
            {
                StreamWriter t = new StreamWriter("path.txt");
                t.WriteLine(i.ToString());
            }
        }

    }
}

