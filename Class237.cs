//Another example
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    delegate int dell(int n1, int n2);
    class program
    {
        public int addition(int n1,int n2)
        {
            return n1 + n2;
        }
        public int substraction(int n1,int n2)
        {
            return n1 - n2;
        }
        static void Main()
        {
            program p=new program();
            dell d1 = new dell(p.addition);
            int res=d1(2, 3);
            Console.WriteLine("Addition=" + res);
                
            dell d2 = new dell(p.substraction);
             res=d2(2, 3);
            Console.WriteLine("Substraction="+res);

        }

    }
}*/
