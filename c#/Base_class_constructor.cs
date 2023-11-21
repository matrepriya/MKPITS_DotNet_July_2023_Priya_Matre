using System;
namespace program
{
    class company
    {
        public string name = "wipro";
        public company()
        {

            Console.WriteLine("based class constructor");
            Console.WriteLine("company name:" + name);

        }
    }
    class employee : company
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            Console.ReadKey();
        }

    }
}


