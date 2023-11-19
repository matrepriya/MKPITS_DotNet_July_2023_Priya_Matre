using System;
namespace program
{
    public class person
    {
        public string name;
        public string address;
    }
    public class student:person
    {
        public int rno;
        public int marks;
    }
    class TestInheritance
    {
        public static void Main(string[]args)
        {
            student p1 = new student();
            p1.rno = 123;
            p1.name = "priyush";
            p1.address = "Nagpur";
            p1.marks = 999;
            Console.WriteLine("rno:" + p1.rno);
            Console.WriteLine("name:" + p1.name);
            Console.WriteLine("address:" + p1.address);
            Console.WriteLine("marks:" + p1.marks);
        }
    }
}
