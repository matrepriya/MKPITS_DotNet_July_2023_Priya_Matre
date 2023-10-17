using System;

namespace program
{
    class program
    {
        public static void Main(string[]args)
        {
             int num = 0;
              int sum = 0;
             float avg =0;
             while(num <=10)
            {
                sum = sum + num;
                avg = sum / 10.0f;
                Console.WriteLine("natural no:" + sum);
                num++;
            }
            Console.WriteLine(" sum of natural no are:" + sum);
            Console.WriteLine("avg of natural no are:" + avg);
        
                 Console.ReadKey();
      }
    }
}
