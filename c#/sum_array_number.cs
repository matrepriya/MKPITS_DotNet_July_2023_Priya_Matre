﻿using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] num = new int[3];
            int sum = 0;
            for( int i=0;i<3;i++)
            {
                Console.WriteLine("enter number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0; i<3;i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("sum of array element ={0]", sum);
            Console.ReadKey();
        }
    }
}
