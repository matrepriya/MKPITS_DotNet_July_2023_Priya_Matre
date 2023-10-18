using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            int sn = 1, en = 2;
            int res1, res2;
            int counter = 1;
            while(counter<=10)
            { 
                res1 = sn * counter;
                res2 = en * counter;
                Console.Write("{0}*{1}={2}", sn, en, res1);
                    Console.Write("\t");
                Console.Write("{0}*{1}={2}", en, counter, res2);
                counter++;
                Console.WriteLine();
            }
            Console.ReadKey();
           }

        }
    }
    