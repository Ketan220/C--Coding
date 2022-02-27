/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class187
    {
        public static void Main()
        {
            int i, j, max, r, c;
            int[,] arr = new int[4, 4];
            for(i=0;i<=3;i++)
            {
                for(j=0;j<=3;j++)
                {
                    Console.WriteLine("Enter elements");
                    arr[i,j] =Convert.ToInt32(Console.ReadLine());
                }    
            }
            max = arr[0, 0];
            r = 0;
            c = 0;
            for (i=0;i<=3;i++)
            {
                for(j=0;j<=3;j++)
                {
                    if(arr[i,j]>max)
                    {
                        max = arr[i, j];
                        r = i;
                        c = j;
                    }
                }
            }
            Console.WriteLine("Largest=" + max);
            Console.WriteLine( r);
            Console.WriteLine( c);
            
        }
    }
}*/
