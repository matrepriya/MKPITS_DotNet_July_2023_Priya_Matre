using System;
namespace program
{
    class program
{
    public static void Main(string[]args)
    {
        int num = 3;
        int counter = 2;
        int flag = 0;
        while(num<20)
        {
            flag = 0;
            counter = 2;
            while (counter < num)
            {
                flag = 1;
                break;
            }
            counter++;

            }
        if (flag == 0)
        {
            Console.WriteLine("prime no:{0}", num);
        }
        num++;
        }
    Console.Readkey ();
    }
   }
}
