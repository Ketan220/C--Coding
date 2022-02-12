/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class42
    {
        public static void Main()
        {
            int n,f1 = 0, f2 = 1, f3, i = 3;
            Console.WriteLine("Enter n. no of terms requires");
            n=Convert.ToInt32(Console.ReadLine());
            
           if(n==0)
            {
               
                Console.WriteLine("f1");
            }
            if(n==1)

            {
             
                Console.WriteLine("f2");
            }
            if(n>2)
            {
                Console.WriteLine("f1");
                Console.WriteLine("f2");
                while(i<=n)
                {
                    f3 = f1 + f2;
                    Console.WriteLine(f3);
                    f1 = f2;
                    f2 = f3;
                    i++;
                }
            }
        }
    }
}*/
