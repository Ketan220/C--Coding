/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class192
    {
        static void Main()
        {
            int i, j, flag = 0;
            int[,] a = new int[4, 4];
            int[,] b = new int[4, 4];
            for(i=0; i<=3; i++)
            {
                for(j=0; j<=3; j++)
                {
                    Console.WriteLine("Enter the element");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            } 
            for(i=0; i<=3; i++)
            {
                for(j=0; j<=3; j++)
                {
                    b[i, j] = a[i, j];
                }
            }
            for(i=0;i<=3; i++)
            {
                for(j=0;j<=3;j++)
                {
                    if(a[i,j]!=b[i,j])
                    {
                        flag = 1;
                        break;

                    }
                }
            }
            if(flag==1)
            {
                Console.WriteLine("Matrix is Symmetrical");
            }
            else
            {
                Console.WriteLine("Matrix is not seymmetrical");
            }

        }
    }
}*/
