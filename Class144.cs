using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int i, j, dsum = 0,usum = 0,lsum = 0;
            int[,] a = new int[4, 4];
            for(i=0;i<=3;i++)
            {
                for(j=0;j<=3;j++)
                {
                    Console.WriteLine("Enter elements");
                    a[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            for(i=0;i<=3;i++)
            {
                for(j=0;j<=3;j++)
                {
                    Console.Write("\t"+a[i,j]);
                }
                Console.WriteLine("\n");
            }
            for(i=0;i<=3;i++)
            {
                for(j =0;j<=3;j++)
                {
                    if(i==j)
                    {
                        dsum=dsum+a[i,j];
                    }
                    if(j>i)
                    {
                        usum=usum+a[i,j];
                    }
                    if(i>j)
                    {
                        lsum=lsum+a[i,j];
                    }
                }
            }
            Console.WriteLine("Digonal element="+dsum);
            Console.WriteLine("Upper Diagonal element="+usum);
            Console.WriteLine("Lower Diagonal element=" + lsum);

        }

    }
}

