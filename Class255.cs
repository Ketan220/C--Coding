//•	throw: A program throws an exception when a problem shows up. This is done using a throw keyword.
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS_Problems
{
    internal class Class255
    {
        static void Main()
        {
            int age=0;
            try
            {
                if(age<18)
                {
                    Console.WriteLine("enter age ");
                    age = Convert.ToInt32(Console.ReadLine());
                    //if the user enters age below 18 then throw the exception
                    throw new Exception("Age can not be less than 18");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Enter the age above 18");
                age=Convert.ToInt32(Console.ReadLine());    
            }
            finally
            {
                Console.WriteLine("finally block execute");
                Console.WriteLine("Age=" + age);
            }
        }
    }
}*/
