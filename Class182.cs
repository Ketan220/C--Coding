//another example
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface bank
    {
        String deposit(int actno, int amt);
        String withdraw(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 1000;
        public String showbalance()
        {
            return "bal is " + bal;
        }
    }
    class saving : account, bank
    {

        public String deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully successfully ,bal is " + bal;
        }
        public String withdraw(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "withdraw successfully ,bal is " + bal;
        }
    }
    class Program
    {
        public static void Main()
        {
            saving b;
            b = new saving();
            String res = b.deposit(1, 200);
            Console.WriteLine(res);

            res = b.withdraw(1, 100);
            Console.WriteLine(res);
            Console.WriteLine(b.showbalance());
        }
    }
}*/