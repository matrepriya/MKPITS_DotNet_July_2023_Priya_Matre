using program;
using System;
namespace program
{
    class company
    {
        public string name = "mkpits";
        public void display ()
        {
            Console.WriteLine("company name:" + name);
        }
    }
    class fancices : company
    {
        public string name = "mkpits";
        public void display()
        {
            base.display();
            Console.WriteLine("fancices name" + name);


        }
    }
}
class program
{
    static void Main()
    {
        fancices f = new fancices();
        f.display();
        Console.ReadKey();
    }
}



