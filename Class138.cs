/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class138
    {
        static void Main()
        {
            int sumx = 0, sumy = 0, sumxy = 0, sumxx = 0, i;
            int[] x = new int[10];
            int[] y = new int[10];
            float s;
            for(i= 0; i <=9;i++)
            {
                Console.WriteLine("Enter elements");
                x[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(i = 0;i <= 9;i++)
            {
                Console.WriteLine("Enter elements");
                y[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<=9;i++)
            {
                sumx=sumx+x[i];
                sumy=sumy+y[i];
                sumxy = sumxy + x[i] * y[i];
                sumxx = sumxx+x[i] * x[i];
            }
            s = (1.0f * sumxy - sumx * sumy) / (sumxx - sumxx * sumxx);
            Console.WriteLine("S=" + s);
        }

    }
}*/
