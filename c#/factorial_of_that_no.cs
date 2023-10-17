using System;
namespace program
{
    class program
    {
        public static void Main(string[] args)
        {
            int number;
        int fact = 1;
        Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            while(number > 0)
            {
                fact = fact* number;
        number--;
            }
    Console.WriteLine("factorial = " + fact);


            Console.ReadKey();
        }
    }
}



    

