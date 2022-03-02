/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class216
    {
        static void Main()
        {
            int num, r;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            r = rsumd(num);
            Console.WriteLine("Sum of digit=" + r);
        }
        static int rsumd(int n)
        {
            if(n==0)
            {
                return (0);
            }
            else
            {
                return (n%10+rsumd(n/10));
            }
        }
    }
}*/
