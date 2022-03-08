//example of creating 3 thread to execute simultaniously
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
            for(int i=1;i<=25;i++)
            {
                Console.WriteLine("I="+i);
            }
        }

        static void Main()
        {
            program p=new program();
            ThreadStart ts=new ThreadStart(p.display);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            Thread t3 = new Thread(ts);
            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}*/
