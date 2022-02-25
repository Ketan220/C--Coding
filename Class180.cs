/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface bank
    {
        string deposit(int actno,int amount);
    }
    class saving:bank
    {
        int actno;
        int balance = 1000;
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            balance=balance+amount;
            return "Amount sucessfully deposited Balance is=" + balance;
        }
    }
    internal class Class180
    {
        public static void Main()
        {
            bank b;
            b = new saving();

            string res = b.deposit(121, 1000);
            Console.WriteLine(res); 
          

        }
    }
}*/
