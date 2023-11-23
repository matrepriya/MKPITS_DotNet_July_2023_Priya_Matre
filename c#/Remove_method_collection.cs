using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(20);
            ar.Add(16);
            Console.WriteLine("arrayList collection withouut sorting");
            foreach(object  ob in ar)
            {
                Console.WriteLine("student rno" + ob);
            }
            ar.Remove(13);
            Console.WriteLine("arrayList collection after removing 13");
            foreach(object ob in ar)
            {
                Console.WriteLine("student rno " + ob);
                ar.Remove(14);
                Console.WriteLine("arrayList collection after removing 1");
                foreach (object ob1 in ar)
                {
                    Console.WriteLine("student rno" + ob1);
                }
                Console.ReadKey();
            }
        }
    }
}

