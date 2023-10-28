using System;
namespace program
{
class program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            Console.WriteLine("Enter number");
            for (int i = 0; i < 5; i++)
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            int j = 0; int k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[i] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr3[k];
                    k++;
                }
                Console.WriteLine("enter number");
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("{ 0}", arr2[i]);
                }
                for (i = 0; i < k; i++)
                {
                    Console.WriteLine("{0} ", arr3[i]);
                }
            }
        }
    
    

