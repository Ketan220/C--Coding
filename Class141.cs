/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class141
    {
        static void Main()
        {
            int i,vote,spvotes = 0;
            int[] count=new int[5];
            char another = 'y';
            for(i=0;i<=4;i++)
            {
                count[i] = 0;
            }
            while(another=='y')
            {
                Console.WriteLine("Enter the candidaten no. [1-5] ");
                vote=Convert.ToInt32(Console.ReadLine());
                if(vote>=1 && vote<=5)
                {
                    count[vote - 1]++;
                }
                else
                {
                    spvotes++;
                }
                Console.WriteLine("Do wish to continue [y/n]");
                another=Convert.ToChar(Console.ReadLine());
            }
            for(i=0;i<=4;i++)
            {
                Console.WriteLine("Cadidate no="+count[i]);
                Console.WriteLine("Votes="+count[i]);
            }
            Console.WriteLine("No. of spoilt vote=" + spvotes);
        }
    }
}*/
