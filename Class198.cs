//C# static field example 2: changing static field
//If you change the value of static field, it will be applied to all the objects.
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
        public string name;
        public static float rateofinterest = 8.5f;

        public Account(int actno,string name)
        {
            this.actno = actno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(actno+" "+name+" "+rateofinterest);
        }
    }
    internal class Class198
    {
        public static void Main()
        {
            Account.rateofinterest = 10.5f; //changing value  
            Account a1 = new Account(1, "Bhavesh");
            Account a2 = new Account(2, "Bhavna");
            a1.display();
            a2.display();
        }
    }

}*/
