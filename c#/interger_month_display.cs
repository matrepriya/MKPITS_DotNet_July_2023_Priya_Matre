using System;
namespace program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            Console.WriteLine("enter integer number");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                case 3:
                case 4:
                case 6:
                case 8:
                    case 12:
                    Console.WriteLine("month havw 31 days");
                    break;
                case 2:
                    Console.WriteLine("month have 20 days");
                    break;
                default:
                    Console.WriteLine("invalid days");
                   }
            Console.ReadKey();
        }
    }
}
