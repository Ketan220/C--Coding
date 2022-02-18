/*4 - create a class book having member variables bookid , title, author, and price 
and a method getdata() with no parameters , create another overloaded method getdata() with 4 parameters*/
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
            title = "JavaScript";
            author = "Aniket";
            price = 3000;
        }
        public void getdata(int bookid,string title,string author,float price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Bookid=" + bookid);
            Console.WriteLine("Booktitle=" + title);
            Console.WriteLine("Bookauthor=" + author);
            Console.WriteLine("Bookprice=" + price);
        }

    }
    internal class Class128
    {
        static void Main()
        {
            Console.WriteLine("-------Overloading method with no parameter");
            book b1 = new book();
            b1.getdata();
            b1.display();

            Console.WriteLine("-------Overloading method with 4 parameter");
            Console.WriteLine("Enter book id");
            int bookid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author");
            string author = Console.ReadLine();
            Console.WriteLine("Enter price");
            float price = Convert.ToSingle(Console.ReadLine());

            book b2 = new book();

            b2.getdata(bookid, title, author, price);
            b2.display();
        }

    }
}*/
