using System;
using System.Xml;
using first;
namespace first
{
    public class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello Namespace");
        }
    }
    namespace second
    {
        public class welcome
        {
            public void SayHello()
            {
                Console.WriteLine("Welcome Namespace");
            }
        }


        namespace program
        {


            public class TestNamespace
            {
                public static void Main()
                {
                    Hello h1 = new Hello();
                    welcome w = new welcome();
                    h1.SayHello();
                    w.SayHello();

                }
            }

        }
    }
}

    











