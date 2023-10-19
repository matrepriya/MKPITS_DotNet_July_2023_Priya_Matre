using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int num = 11;
            do
            {
                Console.WriteLine("num={0}", num);
                num++;
            }
            while (num <= 5);
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
