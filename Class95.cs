using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class95
    {
        struct measure
        {
            public int feet,inches;
        }
        static void Main()
        {
            measure m;
            Console.WriteLine("Enter feet and inches");
            m.feet = Convert.ToInt32(Console.ReadLine());
            m.inches= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Measure=" + m.feet + m.inches);

        }
    }
}
