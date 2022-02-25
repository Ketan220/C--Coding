/*C# Sealed method
The sealed method in C# cannot be overridden further. It must be used with override keyword in method.*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello person");
        }
    }
    class student:person
    {
        public sealed override void display()
        {
            Console.WriteLine("Hello Student");
        }
    }
    class parttime:student
    {
        //public override void display() //error since sealed
        //{
        //    Console.WriteLine("hello");
        //}

    }
    internal class Class183
    {
       public static void Main()
        {
            parttime p = new parttime();
            p.display();
        }
    }

}*/
