﻿using System;
namespace acceptcharacter
{
    class programe
    {
        static void Main(string[]args)
        {
            char ch;
            Console.WriteLine("enter character");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ch"+ch);
            Console.ReadKey();
        }
    }
}
