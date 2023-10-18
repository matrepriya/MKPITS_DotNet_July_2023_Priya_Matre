using System;
namespace program
{
    class program
    {
        public static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("enter limit");
            {
                int fLag;
                Console.WriteLine("enter limit");
                flag = Convert.ToInt32(Console.ReadLine());
                int counter = 1;
                int counter1 = 1;


                while (counter <= 10)
                {
                    counter1 = 1;
                    while (counter1 <= flag)
                    {

                        Console.Write("{0}*{1}={2}", counter, counter1, (counter1 * counter));
                        Console.Write("\t");

                        counter1++;
                    }
                    counter++;
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
    
        
    




