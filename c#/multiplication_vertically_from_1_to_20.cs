using System;
namespace program
{
    class program
    {
        public static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("enter limit:");
            flag = Convert.ToInt32(Console.ReadLine());
            int counter, cnt1;
            for (counter = 1; counter <= 10; counter++)
            {
                cnt1 = 1;
                for (cnt1 = 1; cnt1 < flag; cnt1++)
                {
                    Console.WriteLine("{o}*{1}={2}", cnt1, counter, (cnt1 * counter);
                    Console.WriteLine("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
