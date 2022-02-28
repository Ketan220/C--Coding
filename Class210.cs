//create  a student class and create a arraylist collection of objects of student class
using System;
using System.Collections;

namespace ConsoleApp2
{
    class student
    {
        public int rno;
        public string name;

        public student(int rno,string name)
        {
            this.rno = rno; 
            this.name = name;
        }

    }
    internal class Class210
    {
        static void Main()
        {
            student s1 = new student(1,"Mahesh");
            student s2 = new student(3,"Yamini");
            student s3 = new student(5,"Sam");

            ArrayList al=new ArrayList();
            al.Add(s1);
            al.Add(s2); 
            al.Add(s3);

            foreach(student s in al)
            {
                Console.WriteLine("Rno="+s.rno);
                Console.WriteLine("Name="+s.name);
            }
        }
    }
}
