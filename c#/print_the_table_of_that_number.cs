﻿using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int counter = 1;
            while (counter <= 10)
            {
                result = number * counter;
                Console.WriteLine("{0} * {1} = {2}", number, counter, result);
                counter++;

            }


            Console.ReadKey();
        }
    }
}

