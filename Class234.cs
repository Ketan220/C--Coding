//Queue class of generic collecton
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class234
    {
        static void Main()
        {
            Queue<string> msgs = new Queue<string>();

            msgs.Enqueue("Message 1");
            msgs.Enqueue("Message 2");
            msgs.Enqueue("Message 3");
            msgs.Enqueue("Message 4");
            msgs.Enqueue("Message 5");

            foreach (string msg in msgs)
            {
                Console.WriteLine(msg);
            }

            msgs.Enqueue("Message 6");
            msgs.Enqueue("Message 7");
            Console.WriteLine("The next popping value is:{0}", msgs.Peek());

            foreach (string msg in msgs)
            {
                Console.WriteLine(msg);
            }

            Console.WriteLine("Removing first two");
            msgs .Dequeue ();   
            msgs.Dequeue ();
            foreach (string msg in msgs)
            {
                Console.WriteLine(msg);
            }


        }
    }
}
