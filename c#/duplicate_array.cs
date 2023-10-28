using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] a1 = new int[3];
            int cnt = 0;

            for ( int i =0; i<3; i++)
            {
                Console.WriteLine(" element of array:");
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }

           Console.WriteLine("\n");
            for ( int i = 0; i<3; i++)
            {
                Console.WriteLine("Element of arry -{0}={1}",i, a1[i]);
            }
            Console.WriteLine("\n");
            for ( int i = 0;i<3; i++)
            {
                for ( int j = i+1; j<3; j++)
                {
                    if (a1[i] == a1[j])
                    {
                        cnt++;
                        break;
                    }
                }
            }
                Console.WriteLine("number of duplicate element in array =" + cnt);
                Console.ReadKey();
            
        }
    }
}
