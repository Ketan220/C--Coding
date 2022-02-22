/*Let's see an example of aggregation where Employee class has the reference of Address class as data member. 
 * In such way, it can reuse the members of Address class.*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Address
    {
        public string addressline,city ,state;  
        public  Address(string addressline,string city,string state)
        {
            this.addressline = addressline;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Address address;

        public  Employee(int id,string name,Address address)
        {
            this.id = id;
            this.name = name;   
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine("Id=" + id);
            Console.WriteLine("Name="+name);
            Console.WriteLine("AddressLine="+address.addressline);
            Console.WriteLine("City=" + address.city);
            Console.WriteLine("State="+address.state);

        }
    }
    internal class Class163
    {
        public static void Main()
        {
            Address a1 = new Address("Noida", "Delhi", "Maharashtra");
            Employee e1 = new Employee(1, "krunal", a1);
            e1.display();   
        }
    }
}*/
