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
    class Transactions
    {
        readonly DateTime data = DateTime.Now;
        readonly decimal summ;

        public Transactions(decimal summ)
        {
            this.summ = summ;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Date:{data} Sum:{summ}");
        }
    }
}
