using System;

namespace program
{
    class Book
    {
        int bookid;
        string title, author;
        int price;
        public Book()
        {
            bookid = 1;
            title = " oracle";
            author = "james";
            price = 200;
        }
        public void display()
        {
            Console.WriteLine(" book id =" + bookid);
            Console.WriteLine("book title =" + title);
            Console.WriteLine("book author=" + author);
            Console.WriteLine(" price=" + price);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.ReadLine();
        }
    }
}


