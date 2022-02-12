/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class39
    {
        public static void Main()
        {
            int num, d, sum = 0, i = 1, ori;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            ori = num;
            while (num != 0) 
            {
                d = num % 10;
                sum = sum*10 + d;
                num = num / 10;
            }
            if(sum==ori)
            {
                Console.WriteLine("Number is Pallindrome");
            }
            else
            {
                Console.WriteLine("Number is not Pallindrome");
            }

        }
    }
            
}*/

