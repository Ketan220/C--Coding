/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class217
    {
        static void Main()
        {
            int n, i, r;
            Console.WriteLine("Enter number");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=0;i<n-1;i++)
            {
                r = rfebo(i);
                Console.Write("\t"+r);
            }
        }
        static int rfebo(int pos)
        {
            if(pos==0 || pos==1)
            {
                return (pos);
            }
            else
            {
                return(rfebo(pos-1)+rfebo(pos-2));
            }

        }
    }
}*/
