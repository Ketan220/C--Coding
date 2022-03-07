/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS_Problems
{
    internal class Class262
    {
        static void Main()
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Arr=" + arr[i]);
                }
            }
            catch (IndexOutOfRangeException  ex)
            {
                Console.WriteLine("catch block is executing");
                Console.WriteLine(ex.ToString ());      
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Finally block executed");
                
            }
            Console.WriteLine("bye");
        }
    }
}*/
