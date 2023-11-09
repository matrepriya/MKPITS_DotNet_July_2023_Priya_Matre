using System;
namespace program
{ 
    class student
    {
        public static void display ()
        {
            Console.WriteLine("hello");
        }
        public void shivani()
        {
            Console.WriteLine("hi");
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            student.display();
            student s = new student();
            s.shivani();
        }
    }
}
