/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class137
    {
       static void Main()
        {
            int max, i, pos;
            int[] arr = new int[10];
            for(i=0;i<=9;i++)
            {
                Console.WriteLine("Enter number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            pos = 0;
            for(i=0;i<=9;i++)
            {
                if(arr[i]>max)
                {
                    max= arr[i];
                    pos = i;
                }
            }
            Console.WriteLine("Largest=" + max);
            Console.WriteLine("Position=" + pos);
        }
    }
}*/
