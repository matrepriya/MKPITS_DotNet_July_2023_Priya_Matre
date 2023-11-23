using System;
using System.collections;
namespace ConsoleApp6
{
    class program
    {
        static void Main(string[]args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("priya");
            ar.Add("sachin");
            ar.Add("sagar");
            ar.Add("nilesh");
            //displaying values of arrayList
            foreach (object obj in ar)
            {
                Console.WriteLine("Student name" + obj);
            }
            Console.ReadKey();
        }
    }
}
