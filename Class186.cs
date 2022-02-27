/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class186
    {
        public static void Main()
        {
            int i, j, temp;
            int[,] arr = new int[4,4];
            for(i=0;i<=3;i++)
            {
                for(j=0;j<=3;j++)
                {
                    Console.WriteLine("Enter Elements");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine()); 
                }
            }
            for(i=0;i<=3;i++)
            {
                for(j=0;j<=3;j++)
                {
                    if(j<i)
                    {
                        temp=arr[i,j];
                        arr[i, j] = arr[j, i];
                        arr[j,i]=temp;  
                    }
                }
            }
            for(i=0;i<=3;i++)
            {
                for(j=0;j<=3;j++)
                {
                    Console.Write("\t"+arr[i,j]);

                }
                Console.WriteLine("\n");
            }
        }
    }
}*/
