using System;
namespace leapyearprograme
{
    class program
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter num");
            num=Convert.ToInt32(Console.ReadLine());
            if (num%4==0)
            { 
            Console.WriteLine("is a leap year");
            }
            else
            {
                Console.WriteLine("it is not leap year");
            }
            Console.ReadKey();

        }
    }
}
