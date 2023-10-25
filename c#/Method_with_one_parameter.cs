using System;
namespace program
{
    class program
    {
        static void factorial (int num)// method with one integer parameter
        {
            int fact = 1;
            while (num>0)
            {
                fact *= num;
                num--;
            }
            Console.WriteLine("fact" + fact);
        }
static void Main (string[] args)
        {
            factorial(5);
            Console.ReadKey();
        }
    }
}
