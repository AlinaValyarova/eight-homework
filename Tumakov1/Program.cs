using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Tumakov1
{
    class Program
    {
        static void Main()
        {

            ex91();
        }

        public static void ex91()
        {
            Console.WriteLine("Enter number of needed operation");
            Console.WriteLine("1 - print");
            Console.WriteLine("2 - new");
            Console.WriteLine("3 - exit");
            Console.WriteLine("4 - add money");
            Console.WriteLine("5 - withdraw money");
            string path = @"C:\Users\Allli\source\repos\Sixth homework\clients.txt";
            List<BankAccount> clients = new List<BankAccount>();
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 3)
            {
                switch (num)
                {
                    case 1:
                        ReadFromFile(path, clients);
                        for (int i = 0; i < clients.Count; i++)
                        {

                            BankAccount person = clients[i];
                            Console.WriteLine("Number of account: " + person.ID + " Sum: " + person.balance + " Account type: " + person.AccType);
                            continue;
                        }
                        Main();
                        continue;

                    case 2:
                        BankAccount NewAccount = new BankAccount();
                        Console.WriteLine("Введите номер банковского счета:");
                        long number = BankAccount.ID;
                        Console.WriteLine("Введите баланс банковского счета:");
                        decimal balance;
                        while (!decimal.TryParse(Console.ReadLine(), out balance))
                        {
                            Console.WriteLine("Wrong enter");
                        }
                        Console.WriteLine("Enter account type");
                        Console.WriteLine("1 - saving");
                        Console.WriteLine("2 - current");
                        byte a;
                        while (!byte.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Wrong enter. Try again");
                        }
                        switch (a)
                        {
                            case 1:
                                string abc = number + " " + balance + " saving ";
                                using (StreamWriter writer = new StreamWriter(path, false))
                                {
                                    writer.WriteLine(abc);
                                }
                                Main();
                                continue;
                            case 2:
                                string abc1 = number + " " + balance + " current ";
                                using (StreamWriter writer = new StreamWriter(path, false))
                                {
                                    writer.WriteLine(abc1);
                                }
                                Main();
                                continue;

                            case 3:
                                BankAccount.PutMoney(clients);
                                Main();
                                continue;

                            case 4:
                                BankAccount.TakeMoney(clients);
                                Main();
                                continue;

                            default:
                                Console.WriteLine("Wrong enter!");
                                Main();
                                continue;
                        }


                }
            }
        }

        public static void ex911()
        {
            Song newSong = new Song("n1", "a1");
            Song newSong1 = new Song("n2", "a2", newSong);

            Console.ReadKey();
        }

    }
}

