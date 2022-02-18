//8-example of overloading with differernt parameter type
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class book
    {
        int bookid;
        string title,author;
        float price;

        public void getdata()
        {
            bookid = 1;
            title = "Rd shrma";
            author = "Shreya";
            price = 800;

        }
        //method overloaded 
        public void getdata(int bookid,float price)
        {
            this.bookid = bookid;
            this.price = price; 
        }
        public void getdata(int bookid, string title,float price)
        {
            this.bookid = bookid;
            this.title=title;   
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Bookid=" + bookid);
            Console.WriteLine("Title=" + title);
            Console.WriteLine("Author=" + author);
            Console.WriteLine("Price=" + price);
        }
    }
    internal class Class132
    {
       static void Main()
        {
            Console.WriteLine("--------Overloadinge method 0 parameter-------");
            book b0 = new book();
            b0.getdata();
            b0.display();

            Console.WriteLine("--------Overloadinge method 3 parameter-------");
            book b1 = new book();
            b1.getdata(1, 2000);
            b1.display();


            Console.WriteLine("--------Overloadinge method 3 parameter-------");
            book b2 = new book();
            b2.getdata(121, "C#",2000);
            b2.display();

        }
    }
}*/
