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
        private int ID;
        private decimal Balance { get; set; }
        public enum AccType : byte
        {
            Saving,
            Current
        }
        private AccType Type { get; set; }


        public BankAccount(int iD, decimal balance, AccType type)
        {
            ID = iD;
            Balance = balance;
            Type = type;

        }


        public static void PutMoney( List<BankAccount> list, List<Transactions> list2)
        {
            Console.WriteLine("Enter you ID");
            int YID;
            while (!Int32.TryParse(Console.ReadLine(), out YID))
            {
                Console.WriteLine("Wrong enter. Please try again");
            }

            Console.WriteLine("Enter amount of money you want to add");
            decimal mn;
            while (!Decimal.TryParse(Console.ReadLine(), out mn))
            {
                Console.WriteLine("Wrong enter. Please try again");
            }
            for (int i = 0; i < list.Count; i++)
            {

                BankAccount task = list[i];
                if (task.ID == YID)
                {
                    task.Balance += mn;
                    Transactions tra = new Transactions(task.Balance);
                }

            }

        }
        public static void TakeMoney(List<BankAccount> list, List<Transactions> list2)
        {
            Console.WriteLine("Enter you ID");
            int YID;
            while (!Int32.TryParse(Console.ReadLine(), out YID))
            {
                Console.WriteLine("Wrong enter. Please try again");
            }

            Console.WriteLine("Enter amount of money you want to withdraw");
            decimal mn;
            while (!decimal.TryParse(Console.ReadLine(), out mn))
            {
                Console.WriteLine("Wrong enter. Please try again");
            }
            for (int i = 0; i < list.Count; i++)
            {

                BankAccount task = list[i];
                if (task.ID == YID)
                {
                    if (task.Balance > 0)
                    {
                        if (task.Balance - mn > 0)
                        {
                            task.Balance -= mn;
                            Console.WriteLine($"Balance: {task.Balance}");
                            Transactions tra = new Transactions(task.Balance);
                        }
                        else
                        {
                            Console.WriteLine($"Not enougth money! Balance: {task.Balance}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Something is wrong!");
                    }
                }

            }
            
        }

        public static int GenerateID(BankAccount acc1, BankAccount acc2)
        {
            return acc2.ID = acc1.ID += 1;
        }

    }
}

