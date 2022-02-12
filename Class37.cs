/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class37
    {
        public static void Main()
        {
            int n, m, factn = 1, factm = 1, factnm = 1, i = 1;
            float c;
            Console.WriteLine("Enter the value of n and m");
            n=Convert.ToInt32(Console.ReadLine());
            m=Convert.ToInt32(Console.ReadLine());
            if(n>m)
            {
                while(i<=n)
                {
                    factn = factn * i;
                    i++;
                }
                i = 1;
                while(i<=m)
                {
                    factm = factm * i;
                    i++;
                }
                i = 1;
                while(i<=n-m)
                {
                    factnm = factnm * i;
                    i++;
                }
                c = (factn * 0.1f) / (factm * factnm);
                Console.WriteLine("C="+c);
                
            }
            else
            {
                Console.WriteLine("Equation cant not be solved");
            }

        }
    }
}*/
