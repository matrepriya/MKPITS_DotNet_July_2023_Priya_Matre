﻿using System ;
namespace rectangle
{
    class area
    {
        public static void Main()
        {
            int length,breath,Result;
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breath");
            breath = Convert.ToInt32(Console.ReadLine());
            Result = length * breath;
            Console.WriteLine("area of rectangle = "+Result);
                Console.ReadKey();

        }
    }
}
