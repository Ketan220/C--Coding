/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class135
    {
        static void Main()
        {
            int i, pcount = 0, ncount = 0, zcount = 0;
            int[] arr=new int[10];
            for(i=0;i<=9;i++)
            {
                Console.WriteLine("Enter numbers");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<=9;i++)
            {
                if(arr[i]>=0)
                {
                    pcount++;
                }
                if(arr[i]<0)
                {
                    ncount++;
                }
                if(arr[i]==0)
                {
                    zcount++;   
                }
            }
            Console.WriteLine("Positive numbers=" + pcount);
            Console.WriteLine("Negative numbers=" + ncount);
            Console.WriteLine("Zero numbers=" + zcount);
        }
    }
}*/
