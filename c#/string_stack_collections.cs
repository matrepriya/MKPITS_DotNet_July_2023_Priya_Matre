using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("priya");
            s.Push("nikita");

            s.Push("payal");
            foreach (string val in s)
            {
                Console.WriteLine("name" + val);
            }
            s.Push("ankita");
            Console.WriteLine("last item add" + s.Pop());
            Console.WriteLine("after peek method");
            foreach (string val in s)
            {
                Console.WriteLine("name" + val);
            }
            Console.WriteLine("last item added" + s.Peek());
            Console.WriteLine("after pop method");
            foreach (string val in s)
            {
                Console.WriteLine("name " + val);
            }
            Console.WriteLine("last item added " + s.Pop());
            Console.WriteLine("after pop method");
            foreach (string val in s)
            {
                Console.WriteLine("name" + val);
            }
            Console.ReadLine();
            }
        }
    }


