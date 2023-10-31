u
    sing System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            customer cust = new customer();
            cust.getdata(123, "priya");
            cust.displaydata();
            Console.ReadKey();
        }
        class customer
        { 
            int customer_code;
            string customer_name;
            public void getdata(int cc,string cn)
            {
                customer_code = cc;
                customer_name = cn;
            }
            public void displaydata()
            {
                Console.WriteLine("customer_code" + customer_code);
                Console.WriteLine("customer_name" + customer_name);
            }

        }
    }
}
