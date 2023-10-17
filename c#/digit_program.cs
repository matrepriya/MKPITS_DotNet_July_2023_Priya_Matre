using System;
namespace digitprogram
{
    class program
    {
       public static void Main(string[]args)
        {
            int digit;
            Console.WriteLine("enter a digit");
            digit = Convert.ToInt32(Console.ReadLine());
            switch(digit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("one");
                    break;
                case 3:
                    Console.WriteLine("one");
                    break;
                case 4:
                    Console.WriteLine("one");
                    break;
                case 5:
                    Console.WriteLine("one");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            Console.ReadKey();
        }
    }
}
