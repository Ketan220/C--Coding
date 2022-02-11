//Switch
//if else 
//wap to accept 2 no. and operator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class17
    {
        public static void Main()
        {
            int n1, n2, res=0;
            char op;
            Console.WriteLine("Enter two numbers");
            n1=Convert.ToInt32(Console.ReadLine());
            n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter op");
            op=Convert.ToChar(Console.ReadLine());
            switch(op)
            {
                case '+':
                res = n1 + n2;
                break;

                case '-':
                res = n1 - n2;
                break;

                case '*':
                res = n1 * n2;
                break;

                case '/':
                res = n1 / n2;
                break;

               default:
               Console.WriteLine("invalid");
               break;

                  
            }
            Console.WriteLine("Result=" +res);
            Console.ReadLine();
        }
    }
}
