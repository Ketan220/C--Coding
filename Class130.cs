/*6 create a class student having fields rno, name, course, fees
create a method getdata with no parameters , create overloaded method with 2 parameters, 3 parameters, 4 parameters and display method.*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class student
    {
        int rno;
        string name, course;
        float price;

        public void getdata()
        {
            rno = 1;
            name = "Vedang";
            course = "c++";
            price = 3000;
        }
        public void getdata(int rno,string name)
        {
            this.rno = rno;
            this.name = name;
        }
        public void getdata(int rno, string name,string course)
        {
            this.rno = rno;
            this.name = name;
            this.course = course;
        }
        public void getdata(int rno, string name,string course,int price)
        {
            this.rno = rno;
            this.name = name;
            this.course = course;   
            this.price = price; 
        }
        public void display()
        {
            Console.WriteLine("RollNo=" + rno);
            Console.WriteLine("Name="+name);
            Console.WriteLine("Course=" + course);
        }


    }
    internal class Class130
    {
        static void Main()
        {
            Console.WriteLine("--------Overloadinge method 0 parameter-------");
            student s0=new student();
            s0.getdata();
            s0.display();

            Console.WriteLine("--------Overloadinge method 2 parameter-------");
            student s1 = new student();
            s1.getdata(12, "Sans");
            s1.display();

            Console.WriteLine("--------Overloadinge method 3 parameter-------");
            student s2 = new student();
            s2.getdata(12, "Chintu","Machine learning");
            s2.display();


            Console.WriteLine("--------Overloadinge method 4 parameter-------");
            student s3 = new student();
            s3.getdata(12, "Chintu", "AI",5000);
            s3.display();
        }
    }
}*/
