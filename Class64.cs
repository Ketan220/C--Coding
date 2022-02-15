/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class64
    {
        static void Main()
        {
            int num, r;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            r = sumd(num);
            Console.WriteLine("Sum of digit=" + r);

        }
        static int sumd(int n)
        {
            int d, sum = 0;
            while(n!=0)
            {
                d = n % 10;
                sum = sum + d;
                n = n / 10;

            }
            return sum;
        }
    }
}*/
