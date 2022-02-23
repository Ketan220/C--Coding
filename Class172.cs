//repeat the above program by accepting values from the user
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Account
    {
        public int actno;
        public int balance = 10000;

        public virtual string deposit(int actno, int amount)
        {
            return "deposite method of account class";
        }
        public string showbalance()
        {
            return "Balance=" + balance;

        }
    }
    public class Current:Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount deposited successfully in current class";
        }

    }
    internal class Class172
    {
        public static void Main()
        {
            Account act=new Current();
            Console.WriteLine("Enter acount no.");
            int actno=Convert.ToInt32(Console.ReadLine ());
            Console.WriteLine("Enter amount");
            int amount=Convert.ToInt32(Console.ReadLine());

            string res = act.deposit(actno, amount);
            Console.WriteLine("Account no is=" + act.actno);
            Console.WriteLine(res); 
            string res2 = act.showbalance();
            Console.WriteLine(res2);
         
        }
    }
}*/
