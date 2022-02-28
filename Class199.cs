//C# static field example 3: Counting Objects
//Let's see another example of static keyword in C# which counts the objects.
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
        public static int count = 0;

        public Account(int actno,string name)
        {
            this.actno = actno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine(actno + " " + name);
        }
    }
    internal class Class199
    {
        public static void Main()
        {
            Account a1 = new Account(1, "Sans");
            Account a2 = new Account(2, "Saee");
            Account a3 = new Account(3, "Sejal");
            a1.display();
            a2.display();
            a3.display();
            Console.WriteLine("No. of Objects="+Account.count);

        }
    }
}*/
