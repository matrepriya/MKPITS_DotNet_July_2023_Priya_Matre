using System;
using System.IO.Pipes;

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
    sealed class parttimestudent : student
    {
        public int hours;
    }
   // class newstudent : parttimestudent error
   
    class program
    {
        static void Main(string[] args)
        {
            parttimestudent p = new parttimestudent();
            p.rno = 44;
            p.name = "priya";
            p.hours = 7;
            Console.WriteLine("rno" + p.rno);
            Console.WriteLine("name" + p.name);
            Console.WriteLine("hours" + p.hours);
        }
    }
}

