using System;
namespace squareprograme
{
    class square
    {
        public static void Main()
        {
            int num, sqr;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            sqr = num * num;
            Console.WriteLine("square" + sqr);
            Console.ReadKey();
        }
    }
}
