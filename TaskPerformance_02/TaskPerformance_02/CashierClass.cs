using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPerformance_02
{
    class CashierClass
    {
        private int x;
        public static string getnumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 1000;

            CashierQueue = new Queue<string>();
        }

        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}
