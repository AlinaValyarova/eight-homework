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
            List<BankAccount> clients = new List<BankAccount>();
            List<Transactions> trans = new List<Transactions>();
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 3)
            {
                switch (num)
                {
                    case 1:
                        BankAccount acc1 = new BankAccount(123, 5000, BankAccount.AccType.Saving);

                        BankAccount acc2 = new BankAccount(124, 123, BankAccount.AccType.Current);
                        continue;

                    case 2:
                       
                        continue;
                            
                    case 3:
 
                        BankAccount.PutMoney(clients, trans);  
                        continue;

                            case 4:      
                        BankAccount.TakeMoney(clients, trans);  
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


    }


