using System;
namespace ConsoleApp8
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" enter no");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" num[{0}]={1}" , num[i]);
            }
            Console.ReadKey();
        }
    }
}


