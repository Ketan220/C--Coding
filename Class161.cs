//example of multilevel inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class person
    {
        string name;
        string address;
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void getdisplaypersondata()
        {
            Console.WriteLine("Name="+this.name);   
            Console.WriteLine("Name="+this.address);
        }
    }
    public class employee:person
    {
        int empno;
        int salary;
        string designation;
        public void getemployeedata(int empno,int salary,string designation)
        {
            this.empno = empno;
            this.salary = salary;
            this.designation = designation; 
        }
        public void getdisplayemployeedata()
        {
            Console.WriteLine("Empno="+this.empno );
            Console.WriteLine("salary=" + this.salary);
            Console.WriteLine("Designation" +this.designation); 
        }
    }
    public class parttimeemployee:employee
    {
        int hours;
        public void getparttimeemployeedata(int hours)
        {
            this.hours = hours;
        }
        public void getdisplayparttimeemployee()
        {
            Console.WriteLine("Hours=" + this.hours);
        }
    }
    internal class Class161
    {
        public static void Main()
        {
            parttimeemployee p1=new parttimeemployee();
            p1.getpersondata("Rutu", "Narendra Nagar");
            p1.getdisplaypersondata();
            p1.getemployeedata(1, 15000, "Java Developer");
            p1.getdisplayemployeedata();
            p1.getparttimeemployeedata(5);
            p1.getdisplayparttimeemployee();

        }
    }
}
