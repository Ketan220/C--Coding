/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Account
    {
        public int actno;
        public int balance = 1000;

        public abstract string deposit(int actno, int amount);

        public string showbalance()
        {
            return "Balance=" + balance;
        }
    }

    class Saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int intrest = 500;
            balance = balance + amount + intrest;
            return "Amount successfully deposite with intrest in saving classs";
        }
    }

    class Current:Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount is successfully deposited without intrest in current class";
        }
    }
    internal class Class178
    {
        public static void Main()
        {
            Console.WriteLine("Enter the accoun no.");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount");
            int amount=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type (saving/currrent)");
            string acttype=Console.ReadLine();  

            Account act = null;
            
            if(acttype=="saving")
            {
                act = new Saving();
            }
            else if(acttype=="current")
            {
                act =new Current(); 
            }

            string res=act.deposit(actno, amount);
            Console.WriteLine("Account no is=" + act.actno);
            Console.WriteLine(res);

            res = act.showbalance();
            Console.WriteLine(res);

        }
    }
}*/
