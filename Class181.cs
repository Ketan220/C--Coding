/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface bank
    {
        string deposit(int actno, int amount);
    }
    class account
    {
        public int actno;
        public int balance=1000;
    }
    class saving:account,bank
    {
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount succefully deposit in saving class,Balance is=" + balance; 

        }
    }
    internal class Class181
    {
        public static void Main()
        {
            bank b;

            b= new saving();

            string res = b.deposit(121, 2000);
            Console.WriteLine(res);
        }
    }
}*/
