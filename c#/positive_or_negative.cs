using System;
namespace programe
{
    class programe
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());
            if (num>0)
            {
                Console.WriteLine("num is positive interger ");
            }
            else if(num==2)
            {
                Console.WriteLine("num is negative");
            }
            Console.ReadKey();
        }
    }
}
