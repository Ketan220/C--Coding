/*Destroying Threads
The Abort() method is used for destroying threads.*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class270
    {
        public static void calltochildthread()
        {
            try
            {
                Console.WriteLine("Child thread start");
                for(int counter=0;counter<=10;counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }
        static void Main()
        {
            ThreadStart ts=new ThreadStart(calltochildthread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread t1=new Thread(ts);       
            t1.Start ();


            //stop the main thread for some time
            Thread.Sleep(2000);

            //now abort the child
            Console.WriteLine("In Main: Aborting the Child thread");

            t1.Abort();
            Console.ReadKey();

        }
    }
}*/
