//9-example of overloading with differernt parameter type
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
        String title, author;
        int price;

        //method overloaded 
        public void getdata(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void getdata(int bookid, int price, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void getdata(String author, int bookid, int price, String title)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);

        }
    }

    internal class Class133
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------book1 details1 ----------");
            Book b1 = new Book();
            b1.getdata(1, "html", "abc", 1200);
            b1.display();

            Console.WriteLine("-----------------book1 details2 ----------");
            Book b2 = new Book();
            b2.getdata(1, 1200, "html", "abc");
            b2.display();

            Console.WriteLine("-----------------book1 details3----------");
            Book b3 = new Book();
            b3.getdata("css", 111, 300, "abc");
            b3.display();

        }

    }
}*/
