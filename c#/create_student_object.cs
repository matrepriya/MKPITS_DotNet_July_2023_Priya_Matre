using System;
using System.Collections;
namespace program
{
    class student
    {
        public int rno;
        public string name;
        public student (int rno,string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            student s1 = new student(12, "priya");
            student s2 = new student(14, "sonu");
            ArrayList a1 = new ArrayList();
            a1.Add(s1);
            a1.Add(s2);
           
            foreach (student s in a1)
            {
                Console.WriteLine("rno" + s.rno);
                Console.WriteLine("name" + s.name);
            }    
        }
    }
}
