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
            // task 9.1
            BankAccount acc1 = new BankAccount(123, 1, BankAccount.Acc_Type.Saving);
            BankAccount acc2 = new BankAccount(124, 1000, BankAccount.Acc_Type.Current);



            // task 9.1
            Song newSong = new Song("n1", "a1");
            Song newSong1 = new Song("n2", "a2", newSong);

            Console.ReadKey();

        }

    }
}

