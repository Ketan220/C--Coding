/*create a base class account having fields actno,bal and methods deposit  and showbalance
create a derieved class current inherited from account class and override the deposit method*/
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

        public virtual string deposit(int actno, int amount)
        {
            return "deposite method of account class";
        }
        public string showbalance()
        {
            return "Balance=" + balance;
        }
    }
    public class Current : Account
    {
        public override string deposit(int actno,int amount)
        {
            this.actno = actno;  
            balance = balance + amount;
            return "Amount deposited successfully in current class";
        }
    }
    internal class Class171
    {
        public static void Main()
        {
            Account act =new Current();//runtime polymorphism : base class reference variable having instance of derieved class current
            String res = act.deposit(123, 2000);
            Console.WriteLine("Account no is= " + act.actno);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);
        }
    }
}*/
