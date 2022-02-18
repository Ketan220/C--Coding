/*3 create a class employee having fields empno,empname , designation and salary
create a constructor with no parameters and create another parameterized constructor with 4 parameters*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class employee
    {
        int empno;
        string empname;
        float salary;

        public employee()
        {
            empno = 1;
            empname = "ketan";
            salary = 12000;
        }
        public employee(int empno, string empname, float salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
        }

        public void display()
        {
            Console.WriteLine("Empno=" + empno);
            Console.WriteLine("Empname=" + empname);
            Console.WriteLine("Empsalary=" + salary );
        }
    }

    internal class Class127
    {
        static void Main()
        {
            Console.WriteLine("-----Constructor with no parameter");
            employee e = new employee();
            e.display();


            Console.WriteLine("-----Constructor with  parameter");
            employee e1=new employee(12,"Vikrant",70000);
            e1.display();



            Console.WriteLine("-------Constructor With  parameter accept by user");
            Console.WriteLine("Enter empid");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter empname");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter salary");
            float salary =Convert.ToSingle(Console.ReadLine());

            employee e2=new employee(empid, empname, salary);
            e2.display();

        
        }
    }
}*/
