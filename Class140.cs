/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class140
    {
        static void Main()
        {
            int num, sum = 0, count = 0;
            float avg;
            char another = 'y';
            while(another =='y')
            {
                Console.WriteLine("Enter number");
                num=Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                count++;
                Console.WriteLine("Do you wish to continue[y/n}?");
                another=Convert.ToChar(Console.ReadLine());
            }
            avg = sum / count * 0.1f;
            Console.WriteLine("Average=" + avg);
        }
    }
}*/
