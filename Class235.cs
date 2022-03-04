/*using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        //declaring a delegate to hold reference to a method
        delegate void dell_display();
        //creating a method
        public void display()
        {
            Console.WriteLine("Hello from delegate display method");
        }
        static void Main()
        {
            Program p=new Program();
            //creating object of delegate
            dell_display d1 = new dell_display(p.display);
            //calling the delegate which in turns call the method display
            d1();
        }
    }
}*/
