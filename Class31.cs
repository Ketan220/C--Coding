using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class31
    {
        public static void Main()
        {
            int num,d,sum=0;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                d = num % 10;
                sum = sum * 10 + d;
                num = num / 10;

            }
            while(sum!=0)
            {
                d = sum % 10;
                switch(d)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("first");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("third");
                        break;
                    case 4:
                        Console.WriteLine("fourth");
                        break;
                    case 5:
                        Console.WriteLine("fifth");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    
                        
                }
                sum = sum / 10;


            }
            Console.ReadLine();
        }
    }
}
