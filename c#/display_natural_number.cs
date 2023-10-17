using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int num = 1;
            int sum = 0;
            while(num>0)
            {
                sum = sum + num;
                Console.WriteLine(" natural no:"+sum);
                num++;
            }
            Console.WriteLine("sum of natural" + sum);
                Console.ReadKey();
        }
    }
}
