using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating......");
        }
        public virtual void run()
        {
            Console.WriteLine("Running");
        }
    }
    class dog:Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread");
        }
        public sealed override void run()
        {
            Console.WriteLine("Running fast");
        }
    }
    class babydog:dog
    {
        public override void eat()
        {
            Console.WriteLine("Eating pedigri");
        }
        /*public  override void run()
        {
            Console.WriteLine("Running slowly");
        }*/

    }
    internal class Class184
    {
        public static void Main()
        {
            babydog b=new babydog();
            b.eat();
            b.run();
        }
    }
}
