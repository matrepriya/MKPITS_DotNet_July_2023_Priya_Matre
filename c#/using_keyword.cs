using System;
using first;
using second;
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
        public class Welcome
        {
            public void SayHello()
            {
                Console.WriteLine("Welcome Namespace");
            }
        }
    }
    public class TestNamespace
    {
        public static void Main()
        {
            Hello h1 = new Hello();
            Welcome W1 = new Welcome();
            h1.SayHello();
            W1.SayHello();
            Console.Readkey();
        }
    }
 }











