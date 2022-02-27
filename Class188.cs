/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class188
    {
        public static void Main()
        {
            float max, min;
            float[,] arr = new float[31, 10];
            int i,j,r1, c1, r2, c2;
            for(i=0;i<=30;i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    Console.WriteLine("Enter temperature");
                    arr[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }
            max = arr[0, 0];
            r1 = 0;
            c1 = 0;
            for(i=0;i<=30;j++)
            {
                for(j=0;j<=9;j++)
                {
                    if(arr[i,j]>max)
                    {
                        max = arr[i,j];
                        r1 = i;
                        c1 = j;
                    }
                }
            }
            Console.WriteLine("Max Temp=" + max);
            Console.WriteLine("Day="+r1);
            Console.WriteLine("City"+c1);

            min =arr[0, 0];
            r2 = 0;
            c2 = 0;
            for(i=0;i<=30;i++)
            {
                for(j=0;j<=9;j++)
                {
                    if(min<max)
                    {
                        max=arr[i,j];
                        r2 = i;
                        c2 = j;
                    }
                }
            }
            Console.WriteLine("Min Temp=" + min);
            Console.WriteLine("Day=" + r2);
            Console.WriteLine("City" + c2);


        }
    }
}*/
