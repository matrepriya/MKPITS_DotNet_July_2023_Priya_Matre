using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) goto Even;
                    
                Console.WriteLine(" odd no");
            goto end;
                    
            Even:
                Console.WriteLine("even no");
                end:
                Console.WriteLine("bye");
                Console.ReadKey();
            }
        }
    }

