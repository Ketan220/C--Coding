//Example of invalidcastexception class
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS_Problems
{
    internal class Class260
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Krunal");
            sb.Append("Meshram");
            Console.WriteLine("sb="+sb.ToString());

            object obj = sb;
            Console.WriteLine(obj.ToString());

            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Bye");
        }
    }
}*/
