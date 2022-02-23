//another example of runtime polymorphism by accepting type of account(Saving or current)
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
            return "Deposite method of account class";
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
            return "Amount successfully deposit without intrest in current class";
        }
    }
    public class Saving :Account
    {
        public override string deposit(int actno,int amount)
        {
            this.actno = actno;
            int intrest = 500;
            balance = balance + amount + intrest;
            return "Amount succefully deposited with intrest in saving class";

        }
    }
    internal class Class174
    {
        public static void Main()
        {
            Console.WriteLine("Enter acount no");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited");
            int amount=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter acount type (Saving/Current");
            string acttype = Console.ReadLine();

            Account act = null;

            if(acttype =="Saving")
            {
                act = new Saving();
            }
            else if(acttype =="Current")
            {
                act = new Current();
            }

            string res=act.deposit(actno, amount);
            Console.WriteLine("Account no is=" + act.actno);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);

        }
    }
}*/
