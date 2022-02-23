/*another example of runtime polymorphism (method overriding)
create a base class account having fields actno,bal and methods deposit  and showbalance
create a derieved class current inherited from account class and override the deposit method
create another derieved class saving inherited from account class and override the deposit method (add interest with amount)*/
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
        public int balance = 1000;
        public virtual string deposit(int actno,int amount)
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
            return "Amount deposited successfully without interest in current class";
        }
    }
    public class Saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int intrest = 500;
            balance = balance + amount+intrest;
            return "Amount deposited successfully with intrest in saving class";
        }
    }
    internal class Class173
    {
        public static void Main()
        {
            Account act = new Current();
            Console.WriteLine("Enter account no");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount");
            int amount=Convert.ToInt32(Console.ReadLine());

            string res = act.deposit(actno, amount);
            Console.WriteLine("Account no is=" + act.actno);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);

            
            
            Account sav=new Saving ();
            Console.WriteLine("Enter account no");
            int actno1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount");
            int amount1 = Convert.ToInt32(Console.ReadLine());

            string res1 = sav.deposit(actno, amount);
            Console.WriteLine("Account no is=" + sav.actno);
            Console.WriteLine(res1);
            res1 = sav.showbalance();
            Console.WriteLine(res1);

        }
    }
}*/
