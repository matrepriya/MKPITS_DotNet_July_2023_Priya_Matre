using System;
namespace program
{
class Book
    {
        int bookid;
        string title;
        string author;
        int price;
        public Book()
        {
            Console.WriteLine(" constructor with no parameter called");
            bookid = 123;
            title = "vb.net";
            author = " priya Matre";
            price = 2333;
        }
        public Book(int bookid, string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void Display()
        {
            Console.WriteLine(" book id:" + bookid);
            Console.WriteLine("title:" + title);
            Console.WriteLine("author:" + author);
            Console.WriteLine("price:" + price);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            Book b1 = new Book();
            b1.Display();
        }
    }
}
