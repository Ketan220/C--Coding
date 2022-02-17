//5-methods parameters having same name as classmembers name
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        int empid;
        string empname;
        float empsalary;

        public void getdata(int empid,string empname,float empsalary)
        {
            this.empid = empid;
            this.empname = empname; 
            this.empsalary = empsalary;
        }
        public void showdata()
        {
            Console.WriteLine("Empid=" + empid);
            Console.WriteLine("Empname=" + empname);
            Console.WriteLine("Empsalary="+empsalary);
        }
    }
    internal class Class119
    {
        static void Main()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter empno,empname and empsalary");

            int ei=Convert.ToInt32(Console.ReadLine());
            string en=Convert.ToString(Console.ReadLine());
            float es=Convert.ToSingle(Console.ReadLine());

            emp.getdata(ei, en, es);
            emp.showdata();
        }

        
        
    }
}*/
