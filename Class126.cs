/*2- create a class book and constructor with no parameters and another constructor with 4 parameters.*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public Book()
        {
            bookid = 1;
            title = "Java";
            author ="Muzahid sir";
            price = 2000;
        }
        public Book(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title; 
            this.author = author;   
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Bookid="+bookid );
            Console.WriteLine("Booktitle="+title);
            Console.WriteLine("Bookauthor="+author);
            Console.WriteLine("Bookprice="+price);
        }

    }
    internal class Class125
    {
       static void Main()
        {
            Console.WriteLine("--------Constructor with no parameter-------");
            Book b = new Book();
            b.display();

            Console.WriteLine("--------BOOK1 DETAILS----------");
            Book b1 = new Book(12, "Html", "kb", 1200);
            b1.display();


            Console.WriteLine("-------Constructor With four parameter");
            Console.WriteLine("Enter book id");
            int bookid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter title");
            string title=Console.ReadLine();
            Console.WriteLine("Enter author");
            string author= Console.ReadLine();
            Console.WriteLine("Enter price");
            int price=Convert.ToInt32(Console.ReadLine());  

            Book b2=new Book(bookid,title,author,price);
            b2.display();


        }
    }
}*/