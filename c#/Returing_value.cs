using System;
namespace program
{
    class program
    {
        static int factorial (int num)
        {
            int fact = 1;
            while(num>0)
            {
                fact *= num;
                num--;
                }
            return fact;
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int result = factorial(number);
            Console.WriteLine("fact" + result);
        }
    }
}
