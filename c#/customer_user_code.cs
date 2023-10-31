using System;
namespace program
{ 
    class program
    {
        static void Main(string[]args)
        {
            customer cust = new customer();
            Console.WriteLine("enter a customer code" + " name");
            int cc = Convert.ToInt32(Console.ReadLine());
            string cn = Convert.ToString(Console.ReadLine());
            cust.getdata(cc, cn);
            cust.displaydata();
        }
    }
    class customer
    {
        int customer_code;
        string customer_name;
        public void getdata(int customer_code,string customer_name)
        {
            customer_code = customer_code;
            customer_name = customer_name;
        }
        public void displaydata()
        {
            Console.WriteLine("customer" + customer_code);
            Console.WriteLine("name" + customer_name);

        }
    }
}
 