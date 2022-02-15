/*ing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class65
    {
        static void Main()
        {
            int a, b, r;
            Console.WriteLine("Enter number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            r = pow(a, b);
            Console.WriteLine("Power=" + r);
        }
        static int pow(int x, int y)
        {
            int p = 1, i;
            for(i=1;i<=y;i++)
            {
                p = p * x;

            }
            return p;
        }
    }
}*/
