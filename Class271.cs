/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    internal class program
    {
        public void display()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("I=" + i);
                Thread.Sleep(500);
            }
        }
        static void Main()
        {
            program p=new program();
            ThreadStart ts=new ThreadStart(p.display);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t1.Join();
            t2.Start();
        }
    }
}*/
