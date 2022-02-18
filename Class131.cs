//7 -calling another method from one method
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
            bookid = 187;
            title = "Rich dad poor dad";
            author = "Robert Kiyosaki";
            price = 700;
        }
        public void getdata(int bookid)
        {
            this.bookid = bookid;
            getdata(12, "DSA");
        }
        public void getdata(int bookid,string title)
        {
            this.bookid =bookid;
            this.title = title;
            getdata  (13,"Value Investing","Benjahim Graham");    
        }
        public void getdata(int bookid,string title,string author)
        {
            this.bookid =bookid;
            this.title=title;   
            this.author = author;
            getdata(17, "Psycology of Money", "Chirag desai", 1400);
        }
        public void getdata(int bookid,string titlt,string author,float price)
        {
            this.bookid = bookid;
            this.title = titlt;
            this.author = author;
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
    internal class Class131
    {
        static void Main()
        {
            book b0=new book();
            b0.getdata(12);
            b0.display();
        }
    }
}*/
