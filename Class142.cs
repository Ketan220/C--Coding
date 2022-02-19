/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class142
    {
        static void Main()
        {
            int[] arr = new int[10];
            int i, num, flag = 0;
            for(i=0;i<=9;i++)
            {
                Console.WriteLine("Enter elements");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the number to be searched in the array");
            num=Convert.ToInt32(Console.ReadLine());
            for(i=0;i<=9; i++)
            {
                if(arr[i]==num)
                {
                    Console.WriteLine("Number is preasent");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number is not present");
            }
           
        }
    }
}*/
