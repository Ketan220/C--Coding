/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    sealed class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating.......");
        }
    }
    class dog:Animal
    {
        public void run()
        {
            Console.WriteLine("Runnimg.......");
        }
    }
    internal class Class182
    {
        public static void Main()
        {
            dog d=new dog();
            d.eat();
            d.run();
        }
    }
}*/

//OUTPUT:-Compile Time Error: 'Dog': cannot derive from sealed type 'Animal'