using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOPS_Problems
{
    class Temperature
    {
        int temperature = 0;
        public void showtemp()
        {
            if (temperature == 0)
            {
                throw new TempIsZeroException("Zero temperature found");
            }
            else
            {
                Console.WriteLine("Temperature:{0}" + temperature);
            }
        }
    }

    public class TempIsZeroException : ApplicationException
    {
        public TempIsZeroException(string message) : base(message)
        {

        }

    }

    internal class Class2631
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showtemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.WriteLine("Bye");

        }
    }
}