//Example of event with no-suscribtion
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class publisher
    {

        //declare a delegate to hold ref to a method with 2 int parameter and which return type is int
        public delegate void dell(int n1, int n2);

        //Declare event
        public event dell event1;

        //creating a method to raise the event
        public void raiseevent()
        {
            if (event1 != null)
            {
                //raise the event
                event1(2, 3);
            }
            else
            {
                Console.WriteLine(" no subscription");
            }
        }
    }
    class Class238
    {
        //creating a method addition with 2 int parameter and return type is int
        public void addition(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("result " + res);
        }

        static void Main(string[] args)
        {
            publisher pb = new publisher();
            pb.raiseevent();

        }

    }
}*/
