//18 example of passing array to method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class113
    {
        static void Main()
        {
            int[] created = new int[3];
            created[0] = 1;
            created[1] = 2;
            created[2] = 3;
             createdarray(created);
        }
        static void createdarray(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
