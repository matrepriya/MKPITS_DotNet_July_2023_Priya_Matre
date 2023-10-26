using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            char[] ch = new char[3];
            int sum = 0;
            for (int i=0;i<3;i++)
            {
                Console.WriteLine("enter character");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("{0}", ch[i]);
            }
            Console.ReadKey();
        }
    }
}
