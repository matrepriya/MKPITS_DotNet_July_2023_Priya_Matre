using System;
namespace program
{
    class program
    {
        static int calculate(params int[] args)
        {
            int i, total = 0;
            
            for (i = 0; i < args.Length; i++)
            {
                total = total + args [i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int result = calculate(1, 2, 3);
            Console.WriteLine(" total" + result);
            Console.ReadKey();
        }
    }
} 