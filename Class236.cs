/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //declare a delegate to hold ref to a method with one int parameter and which return type is int
    delegate int del_square(int n1);
    class pragram
    {
        //creating a method square with one int parameter and return type is int
        public int square(int n1)
        {
            return n1 * n1;
        }
        static void Main()
        {
            pragram p=new pragram();
            del_square d1 = new del_square(p.square);
            int res=d1(3);
            Console.WriteLine("Square="+res);
        }
    }
}*/
