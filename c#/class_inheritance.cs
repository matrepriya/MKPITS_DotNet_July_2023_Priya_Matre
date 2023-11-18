using System;
using System.Reflection.Emit;

namespace program
{
    class person
    {

        public string name;
    }
    
    class student : person
    {
        public int rno;
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rno = 111;
            s.name = "sachin";
            Console.WriteLine("rno " + s.rno);
            Console.WriteLine("name " + s.name);
        }
    }
}
