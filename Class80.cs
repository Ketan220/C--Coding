/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class80
    {
        static void Main()
        {
            int mm, yy, lastdate;
            Console.WriteLine("Enter month(1-12) and yy");
            mm=Convert.ToInt32(Console.ReadLine());
            yy=Convert.ToInt32(Console.ReadLine());
            if(mm==1 || mm==3 || mm==5 || mm==7 || mm==8 || mm==10 || mm==12)
            {
                lastdate = 31;
            }
            else
            {
                if(mm==2)
                {
                    if((yy%100==0 && yy%400==0) || (yy%100!=0 && yy%4!=0))
                    {
                        lastdate = 29;
                    }
                    else
                    {
                        lastdate = 28;
                    }
                }
                else
                {
                    lastdate = 30;
                }
            }
            Console.WriteLine("Latdate=" + lastdate);
        }
    }
}*/
