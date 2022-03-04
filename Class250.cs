/*use for this example is that you have a list of Customers that you need to work with. 
 It would be natural to keep track of these Customers via their CustomerID. 
 The Dictionary example will work with instances of the following Customer class:*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class customer 
    {
        public customer(int id,string name)
        {
            Id = id;
            Name = name;    
        }
        private int m_id;

        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }


    }
    internal class Class250
    {
        static void Main()
        {
            Dictionary<int ,customer> customers=new Dictionary<int ,customer>();
            customer cust1 = new customer(1, "cust1");
            customer cust2 = new customer(2, "cust2");
            customer cust3 = new customer(3, "cust3");

            customers.Add(cust1.Id, cust1);
            customers.Add(cust2.Id, cust2);
            customers.Add(cust3.Id, cust3);

            foreach (KeyValuePair<int, customer > custKeyVal in customers)
            {
                Console.WriteLine(
                    "Customer ID: {0}, Name: {1}",
                    custKeyVal.Key,
                    custKeyVal.Value.Name);
            }
        }
    }
}*/
