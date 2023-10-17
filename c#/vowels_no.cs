using System;
namespace vowelsprogrqam
{
    class number
    {
      public  static void Main(string[]args)
        {
            
                char op;
            Console.WriteLine("enter character");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("character is vowels");
                    break;
            }
            Console.ReadKey();
        }
    }
}

