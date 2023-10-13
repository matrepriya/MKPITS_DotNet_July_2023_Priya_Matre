using System;
namespace heightprogram
{
    class height
    {
        static void Main()
        {
            int height;
            Console.WriteLine("enter tst data");
            height = Convert.ToInt32(Console.ReadLine());
            if (height >150)
            {
                Console.WriteLine("enter person is tall ");
            }
            else
            {
                Console.WriteLine("person is DWarf");
            }
            Console.ReadKey();
        }
        }
    }
