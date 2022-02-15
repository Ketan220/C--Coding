/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class76
    {
        static void Main()
        {
            int hrs, min, sec;
            Console.WriteLine("Enter time in hours");
            hrs=Convert.ToInt32(Console.ReadLine());
            min=Convert.ToInt32(Console.ReadLine());
            sec=Convert.ToInt32(Console.ReadLine());
            sec = sec + 1;
            if(sec==60)
            {
                sec = 0;
                min = min + 1;
            }
            if(min==60)
            {
                min = 0;
                hrs=hrs + 1;

            }
            if(hrs==24)
            {
                hrs = 0;
            }
            Console.Write("New Time=" + hrs + min + sec);
        }
    }
}*/
