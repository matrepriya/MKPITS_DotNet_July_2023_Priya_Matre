using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            Queue q = new Queue();
            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');
            Console.WriteLine("current queue:");
            foreach (char c in q) 
            Console.Write(c + "");
            Console.WriteLine();
            q.Enqueue('V');
            q.Enqueue('H');
            Console.WriteLine("current queue:");
            foreach (char c in q) 
            Console.Write(c + "");
            Console.WriteLine();
            Console.WriteLine("Removing some values");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The Removed value:{0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine(" The removed value:{0}", ch);
            Console.ReadKey();

            
        }
    }
}
