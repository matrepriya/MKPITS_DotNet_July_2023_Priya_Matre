using System;
namespace program
{
    class Book
    {
        int bookid;
        string title;
        public void getdata(int bookid, string title)
        {
            Console.WriteLine("method with integer first called");
            this.bookid = bookid;
            this.title = title;

        }
        public void getdata(string title, int bookid)
        {
            this.bookid = bookid;
            this.title = title;

        }
        public void display()
        {
            Console.WriteLine("book id : " + bookid);
            Console.WriteLine("title :"+ title);
                }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter bookid");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            string t1 = Console.ReadLine();
            ;

            Book b2 = new Book();
            b2.getdata(b1, t1);
            b2.display();

            Console.WriteLine("passing string first then integer");
            b2.getdata(t1, b1);
            b2.display();
        }
    }
}




