using System;
namespace evenprogram
{
    class even
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());
            if(num % 2==0)
            {
                Console.WriteLine("num is even");

            }
            else
            {
                Console.WriteLine("num is odd");
                
            }
            Console.ReadKey();
        }
    }
}