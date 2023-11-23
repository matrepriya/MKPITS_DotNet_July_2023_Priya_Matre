using System;
using System.Collections;
namespace ConsoleApp6
{
    class program
    {
        static void Main(string[]args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(20);
            ar.Add(13);
            Console.WriteLine("arrayList collections without sorting");
            foreach(int obj in ar)
            {
                Console.WriteLine("student rno" + obj);
                ar.Insert(2, 17);
                Console.WriteLine("arrayList collections after adding element at 2 position");
                foreach (object ob in ar)
                {

                    Console.WriteLine("student rno " + ob);
                }
                Console.ReadKey();
            }
        }
    }
}

