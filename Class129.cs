//5 create a class book ,overload  method with 0 ,1 ,2,3,4 parameters.
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
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "php";
            author = "Krunal";
            price = 1300;
        }
        public void getdata(int bookid)
        {
            this.bookid = bookid;
        }
        public void getdata(int bookid,string title)
        {
            this.bookid = bookid;
            this.title = title;
        }
        public void getdata(int bookid,string title,string author)
        {
            this.bookid =bookid;
            this.title=title;
            this.author = author;
        }
        public void getdata(int bookid, string title, string author,int price)
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

    internal class Class129
    {
        static void Main()
        {
            Console.WriteLine("--------Overloadinge method 0 parameter-------");
            book b0 = new book();
            b0.getdata();
            b0.display();

            Console.WriteLine("--------Overloadinge method 1 parameter-------");
            book b1 = new book();
            b1.getdata(12);
            b1.display();

            Console.WriteLine("--------Overloadinge method 2 parameter-------");
            book b2 = new book();
            b2.getdata(13,"Linux");
            b2.display();

            Console.WriteLine("--------Overloadinge method 3 parameter-------");
            book b3 = new book();
            b3.getdata(13, "Linux","bhavesh");
            b3.display();

            Console.WriteLine("--------Overloadinge method 4 parameter-------");
            book b4 = new book();
            b4.getdata(13, "Linux", "bhavesh",1500);
            b4.display();
        }
    }
}*/
