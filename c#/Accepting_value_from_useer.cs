using System;
namespace program
{
    class program
    {
        static void Factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("fact" + fact);
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            Factorial(number);
            Console.ReadKey();
        }

    }
}

