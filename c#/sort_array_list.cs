using System;
using System.Collections;
namespace program
{ 


    class program

    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(20);
            ar.Add(21);
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno" + obj);
            }
            Console.WriteLine("capacity :{0}", ar.Capacity);
        
            Console.WriteLine("count :{0}", ar.Count);

            Console.ReadKey();     
        }

        }
    }








