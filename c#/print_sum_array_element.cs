using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" input to element");
                num[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" element{0}={1}", i, num[i]);
            }
            Console.WriteLine("\t");
            Console.WriteLine(" element in array");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", num[i]);
            }
            Console.ReadKey();
        }
    }
}

