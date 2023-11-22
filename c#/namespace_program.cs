using System;
namespace first
{
    public class Hello
    {
        public void SayHello()
        {
            Console.WriteLine(" call Hello first Namespace");
        }
    }
}
  namespace second
  {
    public class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello second Namespace");
        }
    }
  }

public class TestNamespace
{
    public static void Main()
    {
        first.Hello h1 = new first.Hello();
        second.Hello h2= new second.Hello();
        h1.SayHello();
        h2.SayHello();
        Console.ReadKey();
    }
}






        






