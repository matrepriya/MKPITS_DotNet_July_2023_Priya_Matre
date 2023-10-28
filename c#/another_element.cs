
using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            
            for ( int cnt =0; cnt<3; cnt++)
            {
                Console.WriteLine("enter element of arr :-");
                arr1[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("copy process stored");
            for (int cnt = 0; cnt < 3; cnt++) 
            {
                arr2[cnt] = arr1[cnt];
            }
            Console.WriteLine("\n copy process completed :-");
            for (int cnt = 0; cnt < 3; cnt++) 
            {
                Console.WriteLine("element of arr2 :-" + arr2[cnt]);
            }
            Console.ReadKey();
        }
    }
}