/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class74
    {
        static void Main()
        {
            int d1, d2, num, sum = 0, ori;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            ori = num;
            d1 = num % 10;
            num = num / 10;
            d2 = num % 10;
            num = num / 10;
            sum = d1 * d1 * d1 + d2 * d2 * d2 + num * num * num;
            if(sum==ori)
            {
                Console.WriteLine("No. is Amstrong");
            }
            else
            {
                Console.WriteLine("No. is not amstrong");
            }
        }
    }
}*/
