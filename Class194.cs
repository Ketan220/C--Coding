using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class194
    {
        struct emp
        {
            public string name;
            public int age;
            public int bs;

        };
        static void Main()
        {
            emp e;
            Console.WriteLine("Enter namge,age and bs");
            e.name =Console.ReadLine();     
            e.age =Convert.ToInt32(Console.ReadLine()); 
            e.bs =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name=" + e.name);
            Console.WriteLine("Age=" + e.bs);
            Console.WriteLine("Bs=" + e.bs);
        }
    }
}
