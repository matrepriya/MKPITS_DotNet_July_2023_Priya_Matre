using System;
using System.Net.NetworkInformation;

namespace program
{
    class programe
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter test data");
            num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
