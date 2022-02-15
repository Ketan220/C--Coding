/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class82
    {
        static void Main()
        {
            char sex, loc;
            int age;
            Console.WriteLine("Enter the sex[m/f} ,loacality[c/v] and age");
            sex=Convert.ToChar(Console.ReadLine());
            loc=Convert.ToChar(Console.ReadLine()); 
            age=Convert.ToInt32(Console.ReadLine()); 
            if(age>45)
            {
                if(sex=='m' && loc=='c')
                {
                    Console.WriteLine("Max insurance amt=Rs1,00,000");
                }
                if(sex=='f' && loc=='c')
                {
                    Console.WriteLine("Max insurance amt=Rs80,000");
                }
                if (sex == 'm' && loc =='v')
                {
                    Console.WriteLine("Max insurance amt=Rs50,000");
                }
                if(sex=='f' && loc=='v')
                {
                    Console.WriteLine("Max insurance amt=Rs40,000");
                }
               
            }
            else
            {
                Console.WriteLine("Person can not be insured");
            }
        }
    }
}*/
