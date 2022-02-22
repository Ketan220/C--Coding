/*example of hierarchical inheritance
create a base class person having fields name and address
create a deireved class student inherited from person class having fields rno and marks
create another derieved class employee inherited from person class having fields salary and designation
*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class persons
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
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Address="+address);  
        }
    }
    public class student:persons
    {
        int rno;
        int marks;
        public void getstudentdata(int rno,int marks)
        {
            this.rno = rno; 
            this.marks = marks;
        }
        public void getdisplaystudentdata()
        {
            Console.WriteLine("Rno=" + rno);
            Console.WriteLine("Marks=" + marks);
        }
    }
    public class employees:persons
    {
        int salary;
        string designation;
        public void getemployeesdata(int salary,string designation)
        {
            this.salary = salary;
            this.designation = designation; 
        }
        public void getdisplaydemployeesata()
        {
            Console.WriteLine("Salary="+salary);
            Console.WriteLine("Designation=" + designation);
        }
    }
    internal class Class162
    {
        public static void Main()
        {
            student s1=new student();
            s1.getpersondata("Bhavesh", "Nagpur");
            s1.getstudentdata(12, 99);
            s1.getdisplaypersondata();
            s1.getdisplaystudentdata(); 

            employees e1=new employees();
            e1.getpersondata("Bhagyshri", "Hingna");
            e1.getemployeesdata(15000, "Web Developer");
            e1.getdisplaypersondata();
            e1.getdisplaydemployeesata();
        }
    }
}*/
