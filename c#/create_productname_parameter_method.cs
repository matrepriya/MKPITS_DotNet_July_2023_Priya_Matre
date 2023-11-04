using System;
namespace program
{
    class product
    {
        int productid;
        string productname;
        int price, quantity;
        public product()
        {
            productid = 1;
            productname = productname;
            quantity =100;
            price = 100;


        }
        public void display()
        {
            Console.WriteLine(" product id =" + productid);
            Console.WriteLine("product name =" + productname);
            Console.WriteLine(" product quantity =" + quantity);
            Console.WriteLine(" price =" + price);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            product p = new product();
            p.display();
            Console.ReadLine();
        }
    }
}
