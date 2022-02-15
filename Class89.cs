/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class89
    {
        static void Main()
        {
            int num, d, sum = 0, w = 1;
            Console.WriteLine("Enter Binary no.");
            num=Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                d = num % 10;
                sum = sum + d * w;
                w = w * 2;
                num = num / 10;
            }
            Console.WriteLine("Decimal=" + sum);
        }
    }
}*/
