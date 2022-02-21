//example of protected internal access modifier
/*using System;
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

        protected internal void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected internal void getdisplaypersondata()
        {
            Console.WriteLine("Name=" + this.name);
            Console.WriteLine("Address=" + this.address);
        }
    }
    public class student : person
    {
        int rno;
        int marks;
        public void getstudentdata(int rno, int marks)
        {
            //getpersondata("kb", "Mahal");//calling base class method from derieved class
            this.rno = rno;
            this.marks = marks;
        }
        public void getdisplaystudentdata()
        {
            //getdisplaypersondata();//calling base class method from derieved class
            Console.WriteLine("Rno=" + this.rno);
            Console.WriteLine("Marks=" + this.marks);
        }
    }
    internal class testinheritance
    {
        public static void Main()
        {
            student s1 = new student();
            s1.getpersondata("kb", "Mahal"); //since testinhertance class in not derived class of person
            s1.getdisplaypersondata();       //since testinhertance class in not derived class of person
            s1.getstudentdata(1, 40);
            s1.getdisplaystudentdata();
        }

    }
}*/
