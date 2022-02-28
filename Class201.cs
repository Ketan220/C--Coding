//C# Static Constructor example
//Let's see the example of static constructor which initializes the static field rateOfInterest in Account class.
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
        public static float rateofinterest;

        public Account(int actno, string name)
        {
            Console.WriteLine("Instatnce constructor called");
            this.actno = actno;
            this.name = name;
        }
        static Account()
        {
            Console.WriteLine("Static constructor called");
            rateofinterest= 7.5f;

        }
        public void display()
        {
            Console.WriteLine(actno+" "+name+" "+rateofinterest);
        }
    } 
    internal class Class201
    {
        public static void Main()
        {
            Account a1 = new Account(12, "Priya");
            Account a2 = new Account(13, "Sailee");
            a1.display();
            a2.display();   

        }
    }
}*/
