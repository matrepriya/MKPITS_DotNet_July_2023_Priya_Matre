using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            customer cust = new customer();
            cust.customer_code = 123;
            cust.customer_name = "priya";
            Console.WriteLine("customer code" + cust.customer_code);
            Console.WriteLine(" customer name" + cust.customer_name);
        }
        class customer
        {
          public  int customer_code;
          public  string customer_name;
        }
    }
}


