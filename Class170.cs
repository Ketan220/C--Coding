/*Runtime Polymorphism with Data Members

Runtime Polymorphism can't be achieved by data members in C#. Let's see an example where we are accessing the field by 
reference variable which refers to the instance of derived class.*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Animal
    {
        public string color = "White";
    }
    public class Dog:Animal
    {
        public string color = "Black";
    }
    internal class Class170
    {
        public static void Main()
        {
            Animal d = new Dog();
            Console.WriteLine(d.color); 
        }
    }
}*/
