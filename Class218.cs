/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class218
    {
        static void Main()
        {
            int num, d, sum = 0;
            Console.WriteLine("Enter any number");
            num=Convert.ToInt32(Console.ReadLine());    
            while(num!=0)
            {
                d = num % 10;
                sum = sum + (d + 48);
                num = num / 10;
            }
            Console.WriteLine("Sum of Ascii value of digit=" + sum);
        }
    }
}*/
